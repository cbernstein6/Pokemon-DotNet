﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokemon.Data;

#nullable disable

namespace Pokemon.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20240315195232_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pokemon.Models.GymBadge", b =>
                {
                    b.Property<int>("GymBadgeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GymBadgeId"));

                    b.Property<string>("BadgeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("GymBadgeId");

                    b.HasIndex("TrainerId");

                    b.ToTable("GymBadges");
                });

            modelBuilder.Entity("Pokemon.Models.Pokemontable", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokemonId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("PokemonId");

                    b.ToTable("Pokemontables");
                });

            modelBuilder.Entity("Pokemon.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Pokemon.Models.TrainerPokemon", b =>
                {
                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("TrainerId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("TrainerPokemons");
                });

            modelBuilder.Entity("Pokemon.Models.GymBadge", b =>
                {
                    b.HasOne("Pokemon.Models.Trainer", "Trainer")
                        .WithMany("GymBadges")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Pokemon.Models.TrainerPokemon", b =>
                {
                    b.HasOne("Pokemon.Models.Pokemontable", "Pokemon")
                        .WithMany("TrainerPokemons")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon.Models.Trainer", "Trainer")
                        .WithMany("TrainerPokemons")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Pokemon.Models.Pokemontable", b =>
                {
                    b.Navigation("TrainerPokemons");
                });

            modelBuilder.Entity("Pokemon.Models.Trainer", b =>
                {
                    b.Navigation("GymBadges");

                    b.Navigation("TrainerPokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
