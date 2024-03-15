using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Info_Anzeige.Klassen
{
    internal class AnzeigeContext : DbContext
    {
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Hier würden Sie Ihre Verbindungszeichenfolge für die Datenbank angeben
            ConnectionString connection = new ConnectionString();
            optionsBuilder.UseMySql(connection.LoadConnectionString(), new MySqlServerVersion(new Version(10, 4, 23)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Hier können Sie die Konfigurationen für Ihre Modelle festlegen, falls erforderlich
            modelBuilder.Entity<Benutzer>()
                .HasKey(a => a.Benutzer_ID);

            modelBuilder.Entity<Post>()
                .HasKey(a => a.Post_ID);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Author)
                .WithMany(p => p.Posts)
                .HasForeignKey(p => p.Benutzer_ID);

            modelBuilder.Entity<Benutzer>().HasData(
                new Benutzer
                {
                    Benutzer_ID = 1,
                    Name = "Admin",
                    Berechtigung = "Admin",
                    Passwort = "0000"
                }
                );
        }
    }
}
