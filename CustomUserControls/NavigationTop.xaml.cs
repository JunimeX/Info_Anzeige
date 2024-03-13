using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class NavigationTop : UserControl, INotifyPropertyChanged
    {
        public event EventHandler ExitClick;
        public event EventHandler WindowClick;
        public event EventHandler MinimizeClick;
        public event EventHandler MaximizeClick;

        public event PropertyChangedEventHandler? PropertyChanged;

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

        public static DependencyProperty myMinVisibility =
            DependencyProperty.Register("MinVisibility", typeof(Visibility), typeof(NavigationTop), new PropertyMetadata(Visibility.Visible));


        public Visibility MinVisibility
        {
            get { return (Visibility)GetValue(myMinVisibility); }
            set
            {
                SetValue(myMinVisibility, value);
                OnPropertyChanged(nameof(MinVisibility));
            }
        }

        public static DependencyProperty myMaxVisibility =
            DependencyProperty.Register("MaxVisibility", typeof(Visibility), typeof(NavigationTop), new PropertyMetadata(Visibility.Visible));


        public Visibility MaxVisibility
        {
            get { return (Visibility)GetValue(myMaxVisibility); }
            set
            {
                SetValue(myMaxVisibility, value);
                OnPropertyChanged(nameof(MaxVisibility));
            }
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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
