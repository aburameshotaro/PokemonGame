using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGame.Entities
{
    public class Bag
    {
        public int Amount { get; set; }
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }     
    }
}
