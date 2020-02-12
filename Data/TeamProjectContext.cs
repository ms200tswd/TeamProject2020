using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Models;

namespace TeamProject.Data
{
    public class TeamProjectContext : DbContext
    {
        public TeamProjectContext (DbContextOptions<TeamProjectContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Summary> Summaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Summary>().HasKey(s => new { s.TourId, s.UserId });
        }

    }
}
