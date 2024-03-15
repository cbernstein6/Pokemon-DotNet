using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class Pokemontables
    {
        [Key]
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // This could also be a separate Type entity if you want a more complex type system
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }
        // Navigation property for the relationship
        public ICollection<TrainerPokemon> TrainerPokemons { get; set; }
    }
}