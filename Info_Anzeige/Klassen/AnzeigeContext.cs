using Microsoft.EntityFrameworkCore;

namespace Info_Anzeige.Klassen
{
    internal class AnzeigeContext : DbContext
    {
        public DbSet<Benutzer> Benutzers { get; set; }
    }
}
