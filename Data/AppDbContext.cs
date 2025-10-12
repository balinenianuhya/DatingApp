using Microsoft.EntityFrameworkCore;
using DatingApp.Entities; // adjust if your entities namespace is different

namespace DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

     
        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = "Tom-id", DisplayName = "Tom", Email = "tom@test.com" },
                new AppUser { Id = "Bob-id", DisplayName = "Bob", Email = "bob@test.com" },
                new AppUser { Id = "Jane-id", DisplayName = "Jane", Email = "jane@test.com" }
            );
        }            
    }
}   

