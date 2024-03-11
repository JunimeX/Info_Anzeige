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
using Info_Anzeige.Klassen;

namespace Info_Anzeige.GUI
{
    /// <summary>
    /// Interaktionslogik für ConnectionPage.xaml
    /// </summary>
    public partial class ConnectionPage : Page
    {
        public ConnectionString connectionString;

        public ConnectionPage()
        {
            InitializeComponent();
            connectionString = new ConnectionString();
            this.DataContext = connectionString;
            NameBox.myText = connectionString.DatenbankName;
            AdressBox.myText = connectionString.IpAdresse;
            PortBox.myText = connectionString.Port;
            
        }

        private void VerbindenButton_Click(object sender, EventArgs e)
        {
            connectionString.SafeConnectionString();
        }

    }
}
