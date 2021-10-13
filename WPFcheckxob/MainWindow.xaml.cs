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

namespace WPFcheckxob
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String lista = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnlyCzerwone(object sender, RoutedEventArgs e)
        {
            
                c1.IsChecked = true;
                c2.IsChecked = true;
                c3.IsChecked = true;
                c4.IsChecked = true;

                y1.IsChecked = false;
                y2.IsChecked = false;
                y3.IsChecked = false;
                y4.IsChecked = false;

                z1.IsChecked = false;
                z2.IsChecked = false;
                z3.IsChecked = false;
                z4.IsChecked = false;

                n1.IsChecked = false;
                n2.IsChecked = false;
                n3.IsChecked = false;
                n4.IsChecked = false;

                y1.IsEnabled = false;
                y2.IsEnabled = false;
                y3.IsEnabled = false;
                y4.IsEnabled = false;

                z1.IsEnabled = false;
                z2.IsEnabled = false;
                z3.IsEnabled = false;
                z4.IsEnabled = false;

                n1.IsEnabled = false;
                n2.IsEnabled = false;
                n3.IsEnabled = false;
                n4.IsEnabled = false;

        }

        private void AllCzerwone(object sender, RoutedEventArgs e)
        {
            c1.IsChecked = true;
            c2.IsChecked = true;
            c3.IsChecked = true;
            c4.IsChecked = true;
        }

        private void OnlyCzerwoneOff(object sender, RoutedEventArgs e)
        {
                c1.IsChecked = false;
                c2.IsChecked = false;
                c3.IsChecked = false;
                c4.IsChecked = false;

                y1.IsEnabled = true;
                y2.IsEnabled = true;
                y3.IsEnabled = true;
                y4.IsEnabled = true;

                z1.IsEnabled = true;
                z2.IsEnabled = true;
                z3.IsEnabled = true;
                z4.IsEnabled = true;

                n1.IsEnabled = true;
                n2.IsEnabled = true;
                n3.IsEnabled = true;
                n4.IsEnabled = true;

            lista = "";
        }

        private void AllCzerwoneOff(object sender, RoutedEventArgs e)
        {
            c1.IsChecked = false;
            c2.IsChecked = false;
            c3.IsChecked = false;
            c4.IsChecked = false;

            lista = "";
        }

        private void AllYellow(object sender, RoutedEventArgs e)
        {
            y1.IsChecked = true;
            y2.IsChecked = true;
            y3.IsChecked = true;
            y4.IsChecked = true;
        }

        private void AllYellowOff(object sender, RoutedEventArgs e)
        {
            y1.IsChecked = false;
            y2.IsChecked = false;
            y3.IsChecked = false;
            y4.IsChecked = false;


            lista = "";
        }

        private void OnlyYellow(object sender, RoutedEventArgs e)
        {
            c1.IsChecked = false;
            c2.IsChecked = false;
            c3.IsChecked = false;
            c4.IsChecked = false;

            y1.IsChecked = true;
            y2.IsChecked = true;
            y3.IsChecked = true;
            y4.IsChecked = true;

            z1.IsChecked = false;
            z2.IsChecked = false;
            z3.IsChecked = false;
            z4.IsChecked = false;

            n1.IsChecked = false;
            n2.IsChecked = false;
            n3.IsChecked = false;
            n4.IsChecked = false;

            c1.IsEnabled = false;
            c2.IsEnabled = false;
            c3.IsEnabled = false;
            c4.IsEnabled = false;

            z1.IsEnabled = false;
            z2.IsEnabled = false;
            z3.IsEnabled = false;
            z4.IsEnabled = false;

            n1.IsEnabled = false;
            n2.IsEnabled = false;
            n3.IsEnabled = false;
            n4.IsEnabled = false;
        }

        private void OnlyYellowOff(object sender, RoutedEventArgs e)
        {
            y1.IsChecked = false;
            y2.IsChecked = false;
            y3.IsChecked = false;
            y4.IsChecked = false;

            c1.IsEnabled = true;
            c2.IsEnabled = true;
            c3.IsEnabled = true;
            c4.IsEnabled = true;

            z1.IsEnabled = true;
            z2.IsEnabled = true;
            z3.IsEnabled = true;
            z4.IsEnabled = true;

            n1.IsEnabled = true;
            n2.IsEnabled = true;
            n3.IsEnabled = true;
            n4.IsEnabled = true;

            lista = "";
        }

        private void AllZielone(object sender, RoutedEventArgs e)
        {
            z1.IsChecked = true;
            z2.IsChecked = true;
            z3.IsChecked = true;
            z4.IsChecked = true;
        }

        private void AllZieloneOff(object sender, RoutedEventArgs e)
        {
            z1.IsChecked = false;
            z2.IsChecked = false;
            z3.IsChecked = false;
            z4.IsChecked = false;

            lista = "";
        }

        private void OnlyZielone(object sender, RoutedEventArgs e)
        {
            c1.IsChecked = false;
            c2.IsChecked = false;
            c3.IsChecked = false;
            c4.IsChecked = false;

            y1.IsChecked = false;
            y2.IsChecked = false;
            y3.IsChecked = false;
            y4.IsChecked = false;

            z1.IsChecked = true;
            z2.IsChecked = true;
            z3.IsChecked = true;
            z4.IsChecked = true;

            n1.IsChecked = false;
            n2.IsChecked = false;
            n3.IsChecked = false;
            n4.IsChecked = false;

            c1.IsEnabled = false;
            c2.IsEnabled = false;
            c3.IsEnabled = false;
            c4.IsEnabled = false;

            y1.IsEnabled = false;
            y2.IsEnabled = false;
            y3.IsEnabled = false;
            y4.IsEnabled = false;

            n1.IsEnabled = false;
            n2.IsEnabled = false;
            n3.IsEnabled = false;
            n4.IsEnabled = false;
        }

        private void OnlyZieloneOff(object sender, RoutedEventArgs e)
        {
            z1.IsChecked = false;
            z2.IsChecked = false;
            z3.IsChecked = false;
            z4.IsChecked = false;

            c1.IsEnabled = true;
            c2.IsEnabled = true;
            c3.IsEnabled = true;
            c4.IsEnabled = true;

            y1.IsEnabled = true;
            y2.IsEnabled = true;
            y3.IsEnabled = true;
            y4.IsEnabled = true;

            n1.IsEnabled = true;
            n2.IsEnabled = true;
            n3.IsEnabled = true;
            n4.IsEnabled = true;

            lista = "";
        }

        private void AllNiebieskie(object sender, RoutedEventArgs e)
        {
            n1.IsChecked = true;
            n2.IsChecked = true;
            n3.IsChecked = true;
            n4.IsChecked = true;
        }

        private void AllNiebieskieOff(object sender, RoutedEventArgs e)
        {
            n1.IsChecked = false;
            n2.IsChecked = false;
            n3.IsChecked = false;
            n4.IsChecked = false;

            lista = "";
        }

        private void OnlyNiebieskie(object sender, RoutedEventArgs e)
        {
            c1.IsChecked = false;
            c2.IsChecked = false;
            c3.IsChecked = false;
            c4.IsChecked = false;

            y1.IsChecked = false;
            y2.IsChecked = false;
            y3.IsChecked = false;
            y4.IsChecked = false;

            n1.IsChecked = true;
            n2.IsChecked = true;
            n3.IsChecked = true;
            n4.IsChecked = true;

            z1.IsChecked = false;
            z2.IsChecked = false;
            z3.IsChecked = false;
            z4.IsChecked = false;

            c1.IsEnabled = false;
            c2.IsEnabled = false;
            c3.IsEnabled = false;
            c4.IsEnabled = false;

            y1.IsEnabled = false;
            y2.IsEnabled = false;
            y3.IsEnabled = false;
            y4.IsEnabled = false;

            z1.IsEnabled = false;
            z2.IsEnabled = false;
            z3.IsEnabled = false;
            z4.IsEnabled = false;
        }

        private void OnlyNiebieskieOff(object sender, RoutedEventArgs e)
        {
            n1.IsChecked = false;
            n2.IsChecked = false;
            n3.IsChecked = false;
            n4.IsChecked = false;

            c1.IsEnabled = true;
            c2.IsEnabled = true;
            c3.IsEnabled = true;
            c4.IsEnabled = true;

            y1.IsEnabled = true;
            y2.IsEnabled = true;
            y3.IsEnabled = true;
            y4.IsEnabled = true;

            z1.IsEnabled = true;
            z2.IsEnabled = true;
            z3.IsEnabled = true;
            z4.IsEnabled = true;

            lista = "";
        }

        private void DisplayChecked(object sender, RoutedEventArgs e)
        {
            lista = "";
            if (c1.IsChecked == true)
            {
                lista = lista +", " +c1.Content.ToString();
            }
            if (c2.IsChecked == true)
            {
                lista = lista + ", " + c2.Content.ToString();
            }
            if (c3.IsChecked == true)
            {
                lista = lista + ", " + c3.Content.ToString();
            }
            if (c4.IsChecked == true)
            {
                lista = lista + ", " + c4.Content.ToString();
            }
            if (y1.IsChecked == true)
            {
                lista = lista + ", " + y1.Content.ToString();
            }
            if (y2.IsChecked == true)
            {
                lista = lista + ", " + y2.Content.ToString();
            }
            if (y3.IsChecked == true)
            {
                lista = lista + ", " + y3.Content.ToString();
            }
            if (y4.IsChecked == true)
            {
                lista = lista + ", " + y4.Content.ToString();
            }
            if (z1.IsChecked == true)
            {
                lista = lista + ", " + z1.Content.ToString();
            }
            if (z2.IsChecked == true)
            {
                lista = lista + ", " + z2.Content.ToString();
            }
            if (z3.IsChecked == true)
            {
                lista = lista + ", " + z3.Content.ToString();
            }
            if (z4.IsChecked == true)
            {
                lista = lista + ", " + z4.Content.ToString();
            }
            if (n1.IsChecked == true)
            {
                lista = lista + ", " + n1.Content.ToString();
            }
            if (n2.IsChecked == true)
            {
                lista = lista + ", " + n2.Content.ToString();
            }
            if (n3.IsChecked == true)
            {
                lista = lista + ", " + n3.Content.ToString();
            }
            if (n4.IsChecked == true)
            {
                lista = lista + ", " + n4.Content.ToString();
            }

            MessageBox.Show("Twoje wybrane owoce: " + lista);
        }
    }
}
