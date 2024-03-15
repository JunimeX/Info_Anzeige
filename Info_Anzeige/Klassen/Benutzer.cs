using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Info_Anzeige.Klassen
{
    internal class Benutzer : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long benutzer_id;
        public long Benutzer_ID
        {
            get { return benutzer_id; }
            set 
            { 
                benutzer_id = value;
                OnPropertyChanged(nameof(Benutzer_ID));
            }
        }

        [Required]
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
                OnPropertyChanged(nameof(Name)); 
            }
        }

        [Required]
        private string berechtigung;
        public string Berechtigung
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

        public List<Post>? Posts { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
