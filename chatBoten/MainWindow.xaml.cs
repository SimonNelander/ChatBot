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

namespace chatBoten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelpButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Navarrow.Visibility = Visibility.Visible;
            hjalp.Visibility = Visibility.Visible;
            HelpButton.Visibility = Visibility.Hidden;
            HelpButton_Copy.Visibility = Visibility.Hidden;
        }

        private void homebutton_Click(object sender, RoutedEventArgs e)
        {
            HelpButton.Visibility = Visibility.Visible;
            HelpButton_Copy.Visibility = Visibility.Visible;
            hjalp.Visibility = Visibility.Hidden;
            Navarrow.Visibility = Visibility.Hidden;
        }
    }
}
