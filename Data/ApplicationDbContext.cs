using Microsoft.EntityFrameworkCore;
using JG.Task.Addition.Models;


namespace JG.Task.Addition.Data
 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Calculations> Calculations { get; set; }
    }
}
