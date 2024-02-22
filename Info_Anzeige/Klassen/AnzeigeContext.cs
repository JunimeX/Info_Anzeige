using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Info_Anzeige.Klassen
{
    internal class AnzeigeContext : DbContext
    {
        public DbSet<Benutzer> Benutzers { get; set; }
    }
}
