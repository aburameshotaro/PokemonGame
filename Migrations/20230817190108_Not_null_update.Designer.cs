﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonGame.Entities;

#nullable disable

namespace PokemonGame.Migrations
{
    [DbContext(typeof(PokemonDbContext))]
    [Migration("20230817190108_Not_null_update")]
    partial class Not_null_update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PokemonGame.Entities.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChancesToInflictStatus")
                        .HasColumnType("int");

                    b.Property<int?>("InflictsStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Power")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InflictsStatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Attacks");
                });

            modelBuilder.Entity("PokemonGame.Entities.Bag", b =>
                {
                    b.Property<int>("TrainerId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("TrainerId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("Bags");
                });

            modelBuilder.Entity("PokemonGame.Entities.CatchingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatchingRate")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("CatchingItems");
                });

            modelBuilder.Entity("PokemonGame.Entities.Evolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EvolutionByTrade")
                        .HasColumnType("bit");

                    b.Property<int>("FromPokemonSpeciesId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<int>("ToPokemonSpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromPokemonSpeciesId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ToPokemonSpeciesId");

                    b.ToTable("Evolutions");
                });

            modelBuilder.Entity("PokemonGame.Entities.HealingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HpHealed")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<bool>("Revive")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusHealed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("HealingItems");
                });

            modelBuilder.Entity("PokemonGame.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CostForBuy")
                        .HasColumnType("int");

                    b.Property<int>("CostForSell")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PokemonGame.Entities.LevelUpAttack", b =>
                {
                    b.Property<int>("PokemonSpeciesId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("AttackId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("PokemonSpeciesId", "AttackId");

                    b.HasIndex("AttackId");

                    b.ToTable("LevelUpAttacks");
                });

            modelBuilder.Entity("PokemonGame.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PokemonGame.Entities.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Attack1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Attack2Id")
                        .HasColumnType("int");

                    b.Property<int?>("Attack3Id")
                        .HasColumnType("int");

                    b.Property<int?>("Attack4Id")
                        .HasColumnType("int");

                    b.Property<int>("AttackId1")
                        .HasColumnType("int");

                    b.Property<int?>("AttackId2")
                        .HasColumnType("int");

                    b.Property<int?>("AttackId3")
                        .HasColumnType("int");

                    b.Property<int?>("AttackId4")
                        .HasColumnType("int");

                    b.Property<int>("CurrentHp")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxHp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOnTeam")
                        .HasColumnType("int");

                    b.Property<int>("PokemonSpeciesId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialAttack")
                        .HasColumnType("int");

                    b.Property<int>("SpecialDefense")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Attack1Id");

                    b.HasIndex("Attack2Id");

                    b.HasIndex("Attack3Id");

                    b.HasIndex("Attack4Id");

                    b.HasIndex("PokemonSpeciesId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonGame.Entities.PokemonSpecies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasicAttack")
                        .HasColumnType("int");

                    b.Property<int>("BasicDefense")
                        .HasColumnType("int");

                    b.Property<int>("BasicExperienceGivenWhenDefeated")
                        .HasColumnType("int");

                    b.Property<int>("BasicHp")
                        .HasColumnType("int");

                    b.Property<int>("BasicSpecialAttack")
                        .HasColumnType("int");

                    b.Property<int>("BasicSpecialDefense")
                        .HasColumnType("int");

                    b.Property<int>("BasicSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceSpeed")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Type2Id")
                        .HasColumnType("int");

                    b.Property<int>("TypeId1")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId2")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId1");

                    b.HasIndex("TypeId2");

                    b.ToTable("PokemonSpecies");
                });

            modelBuilder.Entity("PokemonGame.Entities.ProbabilityAppearance", b =>
                {
                    b.Property<int>("PokemonSpeciesId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Probability")
                        .HasColumnType("int");

                    b.HasKey("PokemonSpeciesId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("PokemonProbabilityAppearances");
                });

            modelBuilder.Entity("PokemonGame.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("PokemonGame.Entities.TmAttack", b =>
                {
                    b.Property<int>("PokemonSpeciesId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("AttackId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("PokemonSpeciesId", "AttackId");

                    b.HasIndex("AttackId");

                    b.ToTable("TMAttacks");
                });

            modelBuilder.Entity("PokemonGame.Entities.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<bool>("Bot")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("PokemonGame.Entities.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("PokemonGame.Entities.TypeAttackBonus", b =>
                {
                    b.Property<int>("AttackTypeId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("DefenderTypeId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Multiplier")
                        .HasColumnType("int");

                    b.HasKey("AttackTypeId", "DefenderTypeId");

                    b.HasIndex("DefenderTypeId");

                    b.ToTable("TypesAttackBonuses");
                });

            modelBuilder.Entity("PokemonGame.Entities.Attack", b =>
                {
                    b.HasOne("PokemonGame.Entities.Status", "InflictsStatus")
                        .WithMany("Attacks")
                        .HasForeignKey("InflictsStatusId");

                    b.HasOne("PokemonGame.Entities.Type", "Type")
                        .WithMany("Attacks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InflictsStatus");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("PokemonGame.Entities.Bag", b =>
                {
                    b.HasOne("PokemonGame.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Trainer", "Trainer")
                        .WithMany("Bags")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PokemonGame.Entities.CatchingItem", b =>
                {
                    b.HasOne("PokemonGame.Entities.Item", "Item")
                        .WithOne("CatchingItem")
                        .HasForeignKey("PokemonGame.Entities.CatchingItem", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PokemonGame.Entities.Evolution", b =>
                {
                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "FromPokemonSpecies")
                        .WithMany("EvolvesFrom")
                        .HasForeignKey("FromPokemonSpeciesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "ToPokemonSpecies")
                        .WithMany("EvolvesInto")
                        .HasForeignKey("ToPokemonSpeciesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FromPokemonSpecies");

                    b.Navigation("Item");

                    b.Navigation("ToPokemonSpecies");
                });

            modelBuilder.Entity("PokemonGame.Entities.HealingItem", b =>
                {
                    b.HasOne("PokemonGame.Entities.Item", "Item")
                        .WithOne("HealingItem")
                        .HasForeignKey("PokemonGame.Entities.HealingItem", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PokemonGame.Entities.LevelUpAttack", b =>
                {
                    b.HasOne("PokemonGame.Entities.Attack", "Attack")
                        .WithMany("LevelUpAttacks")
                        .HasForeignKey("AttackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "PokemonSpecies")
                        .WithMany("LevelUpAttacks")
                        .HasForeignKey("PokemonSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attack");

                    b.Navigation("PokemonSpecies");
                });

            modelBuilder.Entity("PokemonGame.Entities.Pokemon", b =>
                {
                    b.HasOne("PokemonGame.Entities.Attack", "Attack1")
                        .WithMany()
                        .HasForeignKey("Attack1Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Attack", "Attack2")
                        .WithMany()
                        .HasForeignKey("Attack2Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PokemonGame.Entities.Attack", "Attack3")
                        .WithMany()
                        .HasForeignKey("Attack3Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PokemonGame.Entities.Attack", "Attack4")
                        .WithMany()
                        .HasForeignKey("Attack4Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "PokemonSpecies")
                        .WithMany("Pokemons")
                        .HasForeignKey("PokemonSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Status", "Status")
                        .WithMany("Pokemons")
                        .HasForeignKey("StatusId");

                    b.HasOne("PokemonGame.Entities.Trainer", "Trainer")
                        .WithMany("Pokemons")
                        .HasForeignKey("TrainerId");

                    b.Navigation("Attack1");

                    b.Navigation("Attack2");

                    b.Navigation("Attack3");

                    b.Navigation("Attack4");

                    b.Navigation("PokemonSpecies");

                    b.Navigation("Status");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PokemonGame.Entities.PokemonSpecies", b =>
                {
                    b.HasOne("PokemonGame.Entities.Type", "Type1")
                        .WithMany("PokemonSpeciesType1")
                        .HasForeignKey("TypeId1")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Type", "Type2")
                        .WithMany("PokemonSpeciesType2")
                        .HasForeignKey("TypeId2")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Type1");

                    b.Navigation("Type2");
                });

            modelBuilder.Entity("PokemonGame.Entities.ProbabilityAppearance", b =>
                {
                    b.HasOne("PokemonGame.Entities.Location", "Location")
                        .WithMany("ProbabilityAppearances")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "PokemonSpecies")
                        .WithMany("ProbabilityAppearances")
                        .HasForeignKey("PokemonSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("PokemonSpecies");
                });

            modelBuilder.Entity("PokemonGame.Entities.TmAttack", b =>
                {
                    b.HasOne("PokemonGame.Entities.Attack", "Attack")
                        .WithMany("TmAttacks")
                        .HasForeignKey("AttackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.PokemonSpecies", "PokemonSpecies")
                        .WithMany("TmAttacks")
                        .HasForeignKey("PokemonSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attack");

                    b.Navigation("PokemonSpecies");
                });

            modelBuilder.Entity("PokemonGame.Entities.TypeAttackBonus", b =>
                {
                    b.HasOne("PokemonGame.Entities.Type", "AttackType")
                        .WithMany("TypeAttackBonuses")
                        .HasForeignKey("AttackTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PokemonGame.Entities.Type", "DefenderType")
                        .WithMany("TypeDefendBonuses")
                        .HasForeignKey("DefenderTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AttackType");

                    b.Navigation("DefenderType");
                });

            modelBuilder.Entity("PokemonGame.Entities.Attack", b =>
                {
                    b.Navigation("LevelUpAttacks");

                    b.Navigation("TmAttacks");
                });

            modelBuilder.Entity("PokemonGame.Entities.Item", b =>
                {
                    b.Navigation("CatchingItem")
                        .IsRequired();

                    b.Navigation("HealingItem")
                        .IsRequired();
                });

            modelBuilder.Entity("PokemonGame.Entities.Location", b =>
                {
                    b.Navigation("ProbabilityAppearances");
                });

            modelBuilder.Entity("PokemonGame.Entities.PokemonSpecies", b =>
                {
                    b.Navigation("EvolvesFrom");

                    b.Navigation("EvolvesInto");

                    b.Navigation("LevelUpAttacks");

                    b.Navigation("Pokemons");

                    b.Navigation("ProbabilityAppearances");

                    b.Navigation("TmAttacks");
                });

            modelBuilder.Entity("PokemonGame.Entities.Status", b =>
                {
                    b.Navigation("Attacks");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("PokemonGame.Entities.Trainer", b =>
                {
                    b.Navigation("Bags");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("PokemonGame.Entities.Type", b =>
                {
                    b.Navigation("Attacks");

                    b.Navigation("PokemonSpeciesType1");

                    b.Navigation("PokemonSpeciesType2");

                    b.Navigation("TypeAttackBonuses");

                    b.Navigation("TypeDefendBonuses");
                });
#pragma warning restore 612, 618
        }
    }
}
