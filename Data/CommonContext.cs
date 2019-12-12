using BizzDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace BizzDirectory.Data
{
    public class CommonContext : DbContext
    {
        public CommonContext(DbContextOptions<CommonContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().ToTable("Organization");
        }

    }
}
