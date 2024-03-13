using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using Info_Anzeige.Klassen;
using Microsoft.EntityFrameworkCore;

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
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += TimerTick;
            timer.Start();

            loading_timer = new DispatcherTimer();
            loading_timer.Interval = TimeSpan.FromMilliseconds(5);
            loading_timer.Tick += LoadingTimerTick;
            loading_timer.Start();
        }

        private void TimerTick(object? sender, EventArgs args)
        {
            try
            {
                using (var context = new AnzeigeContext())
                {
                    context.Database.OpenConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es konnte keine Verbindung zum Server erstellt werden. \n\r" +
                                "Fehlermeldung: \n\r" + ex);
            }

            timer.Stop();
            loading_timer?.Stop();

            LoadLoginPage();
        }

        private void LoadingTimerTick(object sender, EventArgs args)
        {
            Image_Radius.Angle += 5;
        }

        private void LoadLoginPage()
        {
            NavigationService.Navigate(new Login());
        }
    }
}
