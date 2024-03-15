using CustomUserControls;
using Info_Anzeige.GUI;
using Info_Anzeige.Klassen;
using Microsoft.VisualBasic;
using System.DirectoryServices;
using System.IO;
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
            ConnectionString file = new ConnectionString();

            if (File.Exists(file.GetFilepath()))
            {
                MainFrame.NavigationService.Navigate(new LoadingPage());
            }
            else
            {
                MainFrame.NavigationService.Navigate(new ConnectionPage());
            }
            
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
                MyNavigation.MaxVisibility = Visibility.Collapsed;
                MyNavigation.MinVisibility = Visibility.Visible;
            }
        }

        private void NavigationTop_WindowClick(object sender, EventArgs e)
        {
            if(MainWindowFrame.WindowState != WindowState.Normal)
            {
                MainWindowFrame.WindowState = WindowState.Normal;
                MyNavigation.MinVisibility = Visibility.Collapsed;
                MyNavigation.MaxVisibility = Visibility.Visible;
            }
        }
    }
}