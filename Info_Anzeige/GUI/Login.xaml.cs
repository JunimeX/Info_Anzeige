using System.Windows.Controls;

namespace Info_Anzeige.GUI
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            Loaded += GuiIsLoaded;
        }

        private void GuiIsLoaded(object sender, EventArgs args)
        {
            NavigationService.RemoveBackEntry();
        }
    }
}
