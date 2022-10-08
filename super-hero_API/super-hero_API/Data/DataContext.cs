﻿

using Microsoft.EntityFrameworkCore;

namespace super_hero_API.Data
{
    public class DataContext : DbContext
    {
      public DataContext(DbContextOptions<DataContext>options): base(options){ }


        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
