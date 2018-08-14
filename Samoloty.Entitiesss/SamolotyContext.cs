using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Samoloty.Entitiesss
{
    public class SamolotyyyyContext : DbContext
    {
        
        public DbSet<Samoloty> Samoloty { get; set; }
        public DbSet<Lot> Loty { get; set; }
        public DbSet<Rezerwacje> Rezerwacjes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("filename=D:\\Projekty\\Samolotyy\\EntityTestowanie\\Samoloty.db");
        }
    }
}
