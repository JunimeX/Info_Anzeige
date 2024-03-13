using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Anzeige.Klassen
{
    class Author
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        
        [Key]
        private long author_id;
        public long Author_ID
        {
            get { return author_id; }
            set 
            { 
                author_id = value;
                OnPropertyChanged(nameof(Author_ID));
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

        public virtual List<Post> Posts { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
