using Microsoft.EntityFrameworkCore;
using Zadanie_2.API.Models;

namespace Zadanie_2.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}
