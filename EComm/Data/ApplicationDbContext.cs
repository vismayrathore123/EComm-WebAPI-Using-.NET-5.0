using EComm.Models;
using Microsoft.EntityFrameworkCore;

namespace EComm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCover> BookCovers{ get; set; }
        public DbSet<BookWritter> BookWritters { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category
        //        {
        //            Id = 1,
        //            Title = "Samsung",
        //            DisplayOrder = 1,
        //        },
        //        new Category
        //        {
        //            Id = 2,
        //            Title = "Realme",
        //            DisplayOrder = 2
        //        });
        //}
    }
}
