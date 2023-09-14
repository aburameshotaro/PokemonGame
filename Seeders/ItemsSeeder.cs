using Newtonsoft.Json;
using PokemonGame.Entities;

namespace PokemonGame.Seeders
{
    public class ItemsSeeder : Seeder
    {
        private readonly string _itemJsonPath = "/Data/items.json";
        private readonly string _itemCatchingJsonPath = "/Data/catching_items.json";
        private readonly string _itemHealingJsonPath = "/Data/healing_items.json";
        public ItemsSeeder(PokemonDbContext pokemonDb) : base(pokemonDb)
        {
        }

        public override void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Items.Any())
                {
                    (var items, var catchingItems, var healingItems) = getItems();
                    _dbContext.Items.AddRange(items);
                    _dbContext.CatchingItems.AddRange(catchingItems);
                    _dbContext.HealingItems.AddRange(healingItems);
                    _dbContext.SaveChanges();
                }
            }
        }

        private (IEnumerable<Item>, IEnumerable<CatchingItem>, IEnumerable<HealingItem>) getItems()
        {
            string jsonItems = File.ReadAllText(_itemJsonPath);
            var items = JsonConvert.DeserializeObject<List<Item>>(jsonItems);
            string jsonCatchingItems = File.ReadAllText(_itemCatchingJsonPath);
            var catchingItems = JsonConvert.DeserializeObject<List<CatchingItem>>(jsonCatchingItems);
            string jsonHealingItems = File.ReadAllText(_itemHealingJsonPath);
            var healingItems = JsonConvert.DeserializeObject<List<HealingItem>>(jsonHealingItems);
            return (items, catchingItems, healingItems);
        }
    }
}
