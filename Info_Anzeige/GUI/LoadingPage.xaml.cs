using System.Windows.Controls;
using System.Windows.Navigation;

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
            LoadLoginPage();
        }


        private void LoadLoginPage()
        {
            NavigationService.Navigate(new Login());
        }
    }
}
