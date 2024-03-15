using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class TrainerPokemon
    {
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int PokemonId { get; set; }
        public Pokemontable Pokemon { get; set; }
        // You can add more properties here like DateCaught
    }
}