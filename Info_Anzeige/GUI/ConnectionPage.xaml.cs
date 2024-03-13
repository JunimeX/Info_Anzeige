using Info_Anzeige.Klassen;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            NavigationService.Navigate(new LoadingPage());
        }


    }
}
