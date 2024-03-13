using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Info_Anzeige.Klassen
{
    internal class Benutzer : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [Key]
        private int benutzerer_id;
        public int Benutzerer_Id
        {
            get { return benutzerer_id; }
            set 
            { 
                benutzerer_id = value;
                OnPropertyChanged(nameof(Benutzerer_Id));
            }
        }

        [Required]
        private int name;
        public int Name
        {
            get { return name; }
            set 
            { 
                name = value; 
                OnPropertyChanged(nameof(Name)); 
            }
        }

        [Required]
        private int berechtigung;
        public int Berechtigung
        {
            get { return berechtigung; }
            set 
            { 
                berechtigung = value; 
                OnPropertyChanged(nameof(Berechtigung));
            }
        }

        [Required]
        private string passwort;
        public string Passwort
        {
            get { return passwort; }
            set 
            { 
                passwort = value;
                OnPropertyChanged(nameof(Passwort));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
