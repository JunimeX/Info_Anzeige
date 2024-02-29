using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Info_Anzeige.GUI
{
    /// <summary>
    /// Interaktionslogik für ConnectionPage.xaml
    /// </summary>
    public partial class ConnectionPage : Page
    {
        private string _datenbankname;

        public string DatenbankName
        {
            get { return this._datenbankname; } 
            set 
            { 
                if(value != null)
                {
                    this._datenbankname = value;
                    OnPropertyChanged();
                }
            }
        }

        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void VerbindenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo du Arschkrampe");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
