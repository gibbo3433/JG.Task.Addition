using Microsoft.EntityFrameworkCore;

namespace JG.Task.Addition.Data
 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
