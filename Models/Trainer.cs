using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string Gender { get; set; }
        // Navigation property for the relationship
        public ICollection<TrainerPokemon> TrainerPokemons { get; set; }
        public ICollection<GymBadge> GymBadges { get; set; }
    }
}