using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
    {
        // Seed data for Pokemon
        modelBuilder.Entity<Pokemontables>().HasData(
            new Pokemontables { PokemonId = 1, Name = "Pikachu", Type = "Electric", Age = 3, Weight = 13.2, Gender = "Male" },
            new Pokemontables { PokemonId = 2, Name = "Charmander", Type = "Fire", Age = 2, Weight = 8.5, Gender = "Female" },
            // Adding more Pokemon
            new Pokemontables { PokemonId = 3, Name = "Bulbasaur", Type = "Grass", Age = 3, Weight = 6.9, Gender = "Male" },
            new Pokemontables { PokemonId = 4, Name = "Squirtle", Type = "Water", Age = 2, Weight = 9.0, Gender = "Male" },
            new Pokemontables { PokemonId = 5, Name = "Eevee", Type = "Normal", Age = 2, Weight = 6.5, Gender = "Female" },
            new Pokemontables { PokemonId = 6, Name = "Jigglypuff", Type = "Fairy", Age = 1, Weight = 5.5, Gender = "Female" },
            new Pokemontables { PokemonId = 7, Name = "Gengar", Type = "Ghost", Age = 4, Weight = 40.5, Gender = "Male" },
            new Pokemontables { PokemonId = 8, Name = "Machop", Type = "Fighting", Age = 2, Weight = 19.5, Gender = "Male" }
        );

        // Seed data for Trainer
        modelBuilder.Entity<Trainer>().HasData(
            new Trainer { TrainerId = 1, Name = "Ash Ketchum", Town = "Pallet Town", Gender = "Male" },
            new Trainer { TrainerId = 2, Name = "Misty", Town = "Cerulean City", Gender = "Female" },
            // Adding more Trainers
            new Trainer { TrainerId = 3, Name = "Brock", Town = "Pewter City", Gender = "Male" },
            new Trainer { TrainerId = 4, Name = "Lance", Town = "Blackthorn City", Gender = "Male" },
            new Trainer { TrainerId = 5, Name = "Cynthia", Town = "Celestic Town", Gender = "Female" },
            new Trainer { TrainerId = 6, Name = "Gary Oak", Town = "Pallet Town", Gender = "Male" }
        );

        // Seed data for GymBadge
        modelBuilder.Entity<GymBadge>().HasData(
            new GymBadge { GymBadgeId = 1, BadgeName = "Boulder Badge", TrainerId = 1 },
            new GymBadge { GymBadgeId = 2, BadgeName = "Cascade Badge", TrainerId = 2 },
            // Adding more GymBadges
            new GymBadge { GymBadgeId = 3, BadgeName = "Thunder Badge", TrainerId = 3 },
            new GymBadge { GymBadgeId = 4, BadgeName = "Rainbow Badge", TrainerId = 4 },
            new GymBadge { GymBadgeId = 5, BadgeName = "Soul Badge", TrainerId = 5 },
            new GymBadge { GymBadgeId = 6, BadgeName = "Marsh Badge", TrainerId = 6 }
        );

        // TrainerPokemon is a join table, adding more relationships
        modelBuilder.Entity<TrainerPokemon>().HasData(
            new TrainerPokemon { TrainerId = 1, PokemonId = 1 },
            new TrainerPokemon { TrainerId = 2, PokemonId = 2 },
            // Mapping new relationships
            new TrainerPokemon { TrainerId = 3, PokemonId = 3 },
            new TrainerPokemon { TrainerId = 4, PokemonId = 4 },
            new TrainerPokemon { TrainerId = 5, PokemonId = 5 },
            new TrainerPokemon { TrainerId = 6, PokemonId = 6 },
            new TrainerPokemon { TrainerId = 1, PokemonId = 7 }, // Let's assume Ash caught a new one!
            new TrainerPokemon { TrainerId = 2, PokemonId = 8 }  // And Misty too!
            // Feel free to add more as needed to simulate complex scenarios
        );
    }
    }
}