using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Info_Anzeige.Klassen;
using Microsoft.EntityFrameworkCore;

namespace Info_Anzeige.GUI
{
    /// <summary>
    /// Interaktionslogik für LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : Page
    {
        public LoadingPage()
        {
            InitializeComponent();
            // Initialisiere die Server Verbindung mit Überprüfung
            Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AnzeigeContext())
                {
                    context.Database.OpenConnection();
                    MessageBox.Show("Verbindung war erfolgreich");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadLoginPage()
        {
            NavigationService.Navigate(new Login());
        }
    }
}
