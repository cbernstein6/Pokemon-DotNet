using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) {}

        public DbSet<Pokemontables> Pokemontables { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerPokemon> TrainerPokemons { get; set; } // This handles the many-to-many relationship
        public DbSet<GymBadge> GymBadges { get; set; } // If you're tracking gym badges as a separate entity

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainerPokemon>()
                .HasKey(tp => new { tp.TrainerId, tp.PokemonId });

            modelBuilder.Entity<TrainerPokemon>()
                .HasOne(tp => tp.Trainer)
                .WithMany(t => t.TrainerPokemons)
                .HasForeignKey(tp => tp.TrainerId);

            modelBuilder.Entity<TrainerPokemon>()
                .HasOne(tp => tp.Pokemon)
                .WithMany(p => p.TrainerPokemons)
                .HasForeignKey(tp => tp.PokemonId);

        }

    }
}