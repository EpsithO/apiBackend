using Microsoft.EntityFrameworkCore;

namespace MonProjet
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ressource> Ressources { get; set; } // Exemple d'une entité "Ressource"

        // Constructeur avec l'option de connexion à MySQL
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Méthode de configuration pour se connecter à MySQL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=maBaseDeDonnees;User=root;Password=monMotDePasse;", 
                    new MySqlServerVersion(new Version(8, 0, 21))); // Assure-toi que la version de MySQL correspond
            }
        }   
    }
}
