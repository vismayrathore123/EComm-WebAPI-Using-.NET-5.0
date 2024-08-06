using EComm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EComm.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
