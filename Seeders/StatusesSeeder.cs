using Newtonsoft.Json;
using PokemonGame.Entities;

namespace PokemonGame.Seeders
{
    public class StatusesSeeder : Seeder
    {
        public StatusesSeeder(PokemonDbContext pokemonDb) : base(pokemonDb)
        {
        }

        public override void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Status.Any())
                {
                    var statuses = getStatuses();
                    _dbContext.Status.AddRange(statuses);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Status> getStatuses()
        {
            string jsonStatuses = File.ReadAllText("/Data/statuses.json");
            var types = JsonConvert.DeserializeObject<List<Status>>(jsonStatuses);
            return types;
        }
    }
}
