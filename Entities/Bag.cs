using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGame.Entities
{
    [PrimaryKey(nameof(TrainerId), nameof(ItemId))]
    public class Bag
    {
        public int Amount { get; set; }
        [Key]
        [Column(Order = 1)]
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }     
    }
}
