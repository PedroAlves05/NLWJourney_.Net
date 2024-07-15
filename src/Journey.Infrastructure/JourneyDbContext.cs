using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Journey.Infrastructure.Entities;

namespace Journey.Infrastructure
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Estudos_A_Parte\\DatabaseNLW_CS\\JourneyDatabase.db");
        }
    }
}
