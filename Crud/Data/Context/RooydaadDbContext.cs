using Crud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Crud.Data.Context
{
    public class RooydaadDbContext : DbContext
    {
        public RooydaadDbContext(DbContextOptions<RooydaadDbContext> options) : base(options)
        {
        }

        DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasMany(a => a.EventImages).WithOne(a => a.Event).HasForeignKey(a => a.EventId);
            base.OnModelCreating(modelBuilder);
        }

    }
}
