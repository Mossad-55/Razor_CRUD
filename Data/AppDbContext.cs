using Microsoft.EntityFrameworkCore;
using RazorCRUD.Models;

namespace RazorCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
