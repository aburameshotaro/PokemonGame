using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokemonGame.Entities;
using PokemonGame.Repos;

namespace PokemonGame.Seeders
{
    public class AttacksSeeder : Seeder
    {
        public readonly string _allAttacksUrl = "https://pokeapi.co/api/v2/move?limit=10000";
        public AttacksSeeder(PokemonDbContext pokemonDb) : base(pokemonDb)
        {
        }

        public async override void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Attacks.Any())
                {
                    var attacks = await getAttacks();
                    _dbContext.Attacks.AddRange(attacks);
                    _dbContext.SaveChanges();
                }
            }
        }

        private async Task<IEnumerable<Attack>> getAttacks()
        {
            List<Attack> attacks = new List<Attack>();
            using HttpClient client = new();
            var json = await client.GetStringAsync(_allAttacksUrl);
            dynamic allAtacks = JObject.Parse(json);
            foreach (var attack in allAtacks.results)
            {
                var attackJson = await client.GetStringAsync(attack.url.ToString());
                dynamic attackDetails = JObject.Parse(attackJson);
                int? inflictedStatusId = await (new StatusRepo(_dbContext)).FindIdByDescription(attackDetails.effect_entries[0].effect.ToString());
                int chanceToInflictStatus = attackDetails.effect_chance ? attackDetails.effect_chance : 100;
                Attack attackDB = new Attack()
                {
                    Id = attackDetails.id,
                    Name = attackDetails.name,
                    Accuracy = attackDetails.accuracy,
                    DamageClass = attackDetails.damage_class.name,
                    Power = attackDetails.power,
                    Priority = attackDetails.priority,
                    TypeId = int.Parse(attackDetails.type.url.ToString().Split("/")[6]),
                    InflictsStatusId = inflictedStatusId.HasValue ? inflictedStatusId : null,
                    ChancesToInflictStatus = inflictedStatusId.HasValue ? chanceToInflictStatus : null,
                };

                attacks.Add(attackDB);
            }

            return attacks;
        }
    }
}
