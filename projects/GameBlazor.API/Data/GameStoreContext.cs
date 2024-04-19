﻿using GameBlazor.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameBlazor.API.Data
{
    public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
    {
        // 객체를 엔터티로 매핑 
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Genre> Genres => Set<Genre>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                
                new { Id = 1, Name = "Fighting"},
                new { Id = 2, Name = "Releplaying" },
                new { Id = 3, Name = "Sports" },
                new { Id = 4, Name = "Racing" },
                new { Id = 5, Name = "Kids and Family" }
                );
        }
    }
}
