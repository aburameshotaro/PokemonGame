using Newtonsoft.Json;
using PokemonGame.Entities;

namespace PokemonGame.Seeders
{
    public class LocationSeeder : Seeder
    {
        public LocationSeeder(PokemonDbContext dbContext) : base(dbContext) { }
        public override void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Locations.Any())
                {
                    var locations = getLocations();
                    _dbContext.Locations.AddRange(locations);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Location> getLocations()
        {
            string jsonLocations = File.ReadAllText("/Data/locations.json");
            var locations = JsonConvert.DeserializeObject<List<Location>>(jsonLocations);
            return locations;
        }
    }
}
