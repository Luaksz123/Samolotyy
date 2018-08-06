using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Samoloty.Entities;
namespace Samoloty.Data
{
    class SamolotyContext: DbContext
    {
        public DbSet <Lot> Loty { get; set; }
        public DbSet<Samolot> Samoloty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Samoloty.db");
        }
    }
}
