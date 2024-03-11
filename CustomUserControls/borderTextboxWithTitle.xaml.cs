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
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomUserControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomUserControls;assembly=CustomUserControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public partial class borderTextboxWithTitle : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public borderTextboxWithTitle()
        {
            InitializeComponent();
        }

        public static DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(borderTextboxWithTitle), new PropertyMetadata(""));
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set 
            { 
                SetValue(TitleProperty, value);
                OnPropertyChanged(nameof(Title));
            }
        }

        public static DependencyProperty myBackgroundProperty =
           DependencyProperty.Register("myBackground", typeof(string), typeof(borderTextboxWithTitle), new PropertyMetadata(""));
        public string myBackground
        {
            get { return (string)GetValue(TitleProperty); }
            set
            {
                SetValue(TitleProperty, value);
                OnPropertyChanged(nameof(myBackground));
            }
        }

        public static DependencyProperty TextProperty =
            DependencyProperty.Register("myText", typeof(string), typeof(borderTextboxWithTitle), new PropertyMetadata(""));

        public string myText
        {
            get { return (string)GetValue(TextProperty); }
            set 
            { 
                SetValue(TextProperty, value);
                OnPropertyChanged(nameof(myText));
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
