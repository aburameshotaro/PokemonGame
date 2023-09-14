using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PokemonGame.Entities;

namespace PokemonGame.Seeders
{
    public class TypesSeeder : Seeder
    {
        public TypesSeeder(PokemonDbContext pokemonDb) : base(pokemonDb)
        {
        }

        public override void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Types.Any())
                {
                    var types = getTypes();
                    _dbContext.Types.AddRange(types);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Entities.Type> getTypes()
        {
            string jsonTypes = File.ReadAllText("/Data/types.json");
            var types = JsonConvert.DeserializeObject<List<Entities.Type>>(jsonTypes);
            return types;
        }
    }
}
