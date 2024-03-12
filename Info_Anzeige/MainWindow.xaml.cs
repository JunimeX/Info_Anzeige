using CustomUserControls;
using Info_Anzeige.GUI;
using System.Windows;

namespace Info_Anzeige
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new ConnectionPage());
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void NavigationTop_ExitClick(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NavigationTop_MinimizeClick(object sender, EventArgs e)
        {
            if (MainWindowFrame.WindowState != WindowState.Minimized)
            {
                MainWindowFrame.WindowState = WindowState.Minimized;
            }
        }

        private void NavigationTop_MaximizeClick(object sender, EventArgs e)
        {
            if(MainWindowFrame.WindowState != WindowState.Maximized)
            {
                MainWindowFrame.WindowState= WindowState.Maximized;
            }
        }

        private void NavigationTop_WindowClick(object sender, EventArgs e)
        {
            if(MainWindowFrame.WindowState != WindowState.Normal)
            {
                MainWindowFrame.WindowState = WindowState.Normal;
            }
        }
    }
}