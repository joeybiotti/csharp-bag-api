using Microsoft.EntityFrameworkCore;
using BagAPI.Models;

namespace BagAPI.Data
{
    public class BagAPIContext : DbContext
    {
        public BagAPIContext(DbContextOptions<BagAPIContext> options)
            : base(options)
        { }
            public DbSet<Toy> Toy {get; set;}
            public DbSet<Child> Child {get; set;}

            protected override void OnModelCreating (ModelBuilder modelBuilder)
            {
                //if a model has a date filed, that should be generated in the database.
            }
     }
}