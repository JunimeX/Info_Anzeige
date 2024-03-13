using Microsoft.EntityFrameworkCore;

namespace Info_Anzeige.Klassen
{
    internal class AnzeigeContext : DbContext
    {
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authoren { get; set; }

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
                .HasKey(a => a.Benutzerer_Id);

            modelBuilder.Entity<Post>()
                .HasKey(a => a.Post_ID);

            modelBuilder.Entity<Author>()
                .HasKey(a => a.Author_ID);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Author)
                .WithMany(p => p.Posts)
                .HasForeignKey(p => p.Author_ID);
        }
    }
}
