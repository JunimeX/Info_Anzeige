using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomUserControls
{
    /// <summary>
    /// Interaktionslogik für ProjektBorderButton.xaml
    /// </summary>
    public partial class ProjektBorderButton : UserControl
    {
        public ProjektBorderButton()
        {
            InitializeComponent();
        }

        public static DependencyProperty BContentProperty =
            DependencyProperty.Register("BContent", typeof(string), typeof(ProjektBorderButton), new PropertyMetadata(""));
        public string BContent
        {
            get { return (string)GetValue(BContentProperty); }
            set { SetValue(BContentProperty, value); }
        }

        public event EventHandler Click;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            // Weiterleiten des Ereignisses an den Aufrufer
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
