using Microsoft.EntityFrameworkCore;
using Sknowed.Core.Entities.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Persistance
{
    public class SknowedDbContext : DbContext
    {
        public SknowedDbContext(DbContextOptions<SknowedDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SknowedDbContext).Assembly);
            // seed data from configurations
        }
    }
}
