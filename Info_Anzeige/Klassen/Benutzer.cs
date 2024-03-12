using System.ComponentModel.DataAnnotations;

namespace Info_Anzeige.Klassen
{
    internal class Benutzer
    {
        [Key]
        private int benutzererid;
        public int Benutzererid
        {
            get { return benutzererid; }
            set { benutzererid = value; }
        }

        private int name;
        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        private int berechtigung;
        public int Berechtigung
        {
            get { return berechtigung; }
            set { berechtigung = value; }
        }

        private string passwort;
        public string Passwort
        {
            get { return passwort; }
            set { passwort = value; }
        }
    }
}
