using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using Info_Anzeige.Klassen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Info_Anzeige.GUI
{
    /// <summary>
    /// Interaktionslogik für LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : Page
    {

        private DispatcherTimer timer;
        private DispatcherTimer loading_timer;

        public LoadingPage()
        {
            InitializeComponent();
            Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, EventArgs e)
        {
            loading_timer = new DispatcherTimer();
            loading_timer.Interval = TimeSpan.FromMilliseconds(5);
            loading_timer.Tick += LoadingTimerTick;
            loading_timer.Start();

            var database_context = new AnzeigeContext();

            try
            {
                using (var context = new AnzeigeContext())
                {
                    context.Database.OpenConnection();
                    context.Database.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es konnte keine Verbindung zum Server erstellt werden. \n\r" +
                                "Fehlermeldung: \n\r" + ex);
            }

            if (database_context.Database.CanConnect())
            {
                using (var dbcontext = new AnzeigeContext())
                {
                    dbcontext.Database.OpenConnection();
                    dbcontext.Database.Migrate();
                                 
                }
                    LoadLoginPage();
            }
            else
            {
                LoadConnectionPage();
            }
            loading_timer?.Stop();

            
        }

        private void LoadingTimerTick(object sender, EventArgs args)
        {
            Image_Radius.Angle += 5;
        }

        private void LoadConnectionPage()
        {
            NavigationService.GoBack();
        }

        private void LoadLoginPage()
        {
            NavigationService.Navigate(new Login());
        }
    }
}
