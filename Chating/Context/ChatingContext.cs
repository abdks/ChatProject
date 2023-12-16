using Chating.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chating.Context
{
    public class ChatingContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABDULLAH;initial catalog=Chating;integrated Security=true");
        }
        public DbSet<dene> Denes { get; set; }
    }
}
