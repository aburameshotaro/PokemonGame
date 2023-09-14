﻿using PokemonGame.Entities;

namespace PokemonGame.Seeders
{
    public abstract class Seeder
    {
        protected readonly PokemonDbContext _dbContext;
        public Seeder(PokemonDbContext pokemonDb) 
        {
            _dbContext = pokemonDb;
        }
        public abstract void Seed();
    }
}
