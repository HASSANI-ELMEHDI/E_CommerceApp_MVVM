using E_CommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceApp.Data
{
    
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1OOGJDP\\VALL;Database=CAT_DB_8;Trusted_Connection=True;TrustServerCertificate=True");
        }
        */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public ApplicationDbContext()
        {

        }
    }
}
