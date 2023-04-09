using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=EMREVIVO;Database=EntityFrameworkProject;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Coach> Coaches { get; set; }
    }
}
