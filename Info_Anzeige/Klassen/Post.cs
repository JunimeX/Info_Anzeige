using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Anzeige.Klassen
{
    class Post : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [Key]
        private long post_id;
        public long Post_ID
        {
            get { return post_id; }
            set
            {
                post_id = value;
                OnPropertyChanged(nameof(Post_ID));
            }
        }

        [Required]
        private string titel;
        public string Titel
        {
            get { return titel; }
            set
            {
                titel = value;
                OnPropertyChanged(nameof(Titel));
            }
        }

        [ForeignKey(nameof(author_id))]
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
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        private DateTime erstellungs_datum;
        public DateTime Erstellungs_Datum
        {
            get { return erstellungs_datum; }
            set
            {
                erstellungs_datum = value;
                OnPropertyChanged(nameof(Erstellungs_Datum));
            }
        }

        private bool sichtbarkeit_lehrer;
        public bool Sichtberkeit_Lehrer
        {
            get { return sichtbarkeit_lehrer; }
            set
            {
                sichtbarkeit_lehrer = value;
                OnPropertyChanged(nameof(Sichtberkeit_Lehrer));
            }
        }

        private bool sichtbarkeit_schüler;
        public bool Sichtberkeit_Schüler
        {
            get { return sichtbarkeit_schüler; }
            set
            {
                sichtbarkeit_schüler = value;
                OnPropertyChanged(nameof(Sichtberkeit_Schüler));
            }
        }

        public virtual Author Author { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
