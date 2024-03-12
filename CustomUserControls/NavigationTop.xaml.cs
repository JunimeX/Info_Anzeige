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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomUserControls
{
    /// <summary>
    /// Interaktionslogik für NavigationTop.xaml
    /// </summary>
    public partial class NavigationTop : UserControl
    {
        public event EventHandler ExitClick;
        public event EventHandler WindowClick;
        public event EventHandler MinimizeClick;
        public event EventHandler MaximizeClick;

        public NavigationTop()
        {
            InitializeComponent();
        }

        public static DependencyProperty MyLableContentProperty = 
            DependencyProperty.Register("MyTitle", typeof(string), typeof(NavigationTop), new PropertyMetadata(""));
        public string MyTitle
        {
            get { return (string)GetValue(MyLableContentProperty); }
            set { SetValue(MyLableContentProperty, value); }
        }
        


        private void MaximizeButtonClick(object sender, RoutedEventArgs e)
        {
            MaximizeClick?.Invoke(this, EventArgs.Empty);
        }
        private void WindowButtonClick(object sender, RoutedEventArgs e)
        {
            WindowClick?.Invoke(this, EventArgs.Empty);
        }
        private void MinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            MinimizeClick?.Invoke(this, EventArgs.Empty);
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            ExitClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
