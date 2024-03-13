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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomUserControls
{
    /// <summary>
    /// Interaktionslogik für ProjektBorderButton.xaml
    /// </summary>
    public partial class ProjektBorderButton : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ProjektBorderButton()
        {
            InitializeComponent();
        }

        private static DependencyProperty BContentProperty =
            DependencyProperty.Register("BContent", typeof(string), typeof(ProjektBorderButton), new PropertyMetadata(""));
        public string BContent
        {
            get { return (string)GetValue(BContentProperty); }
            set 
            { 
                SetValue(BContentProperty, value); 
                OnPropertyChanged(nameof(BContent));
            }
        }

        private static DependencyProperty RoundCornerButtonBackgroundProperty =
           DependencyProperty.Register("RoundCornerButtonBackground", typeof(Brush), typeof(ProjektBorderButton), new PropertyMetadata(Brushes.Transparent));

        public Brush RoundCornerButtonBackground
        {
            get { return (Brush)GetValue(RoundCornerButtonBackgroundProperty); }
            set { SetValue(RoundCornerButtonBackgroundProperty, value); }
        }

        private static DependencyProperty RoundCornerButtonForegroundProperty =
           DependencyProperty.Register("RoundCornerForeBackground", typeof(Brush), typeof(ProjektBorderButton), new PropertyMetadata(Brushes.Transparent));

        public Brush RoundCornerButtonForeground
        {
            get { return (Brush)GetValue(RoundCornerButtonForegroundProperty); }
            set 
            { 
                SetValue(RoundCornerButtonForegroundProperty, value);
                OnPropertyChanged(nameof(RoundCornerButtonForeground));
            }
        }

        public event EventHandler? Click;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            // Weiterleiten des Ereignisses an den Aufrufer
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
