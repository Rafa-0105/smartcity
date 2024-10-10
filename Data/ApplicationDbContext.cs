using Microsoft.EntityFrameworkCore;
using RestFul_api.Models;

namespace RestFul_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Disaster> Disasters { get; set; }
    }
}
