
namespace CRUDApp.Models;
using Microsoft.EntityFrameworkCore;
public class AppDbContext: DbContext{
     public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDApp.Models.Book> Books { get; set; }
        public DbSet<CRUDApp.Models.Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(u => u.books)
                .WithOne(p => p.category)
                .HasForeignKey(p => p.CategoryId);

            // Other configurations...
        }
}