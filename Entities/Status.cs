namespace PokemonGame.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Pokemon> Pokemons { get; set; }
        public virtual List<Attack> Attacks { get; set; }
    }
}