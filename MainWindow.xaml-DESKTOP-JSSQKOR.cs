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

namespace MyLove
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

    void Rolover()
        {
            Heart1.Visibility = Visibility.Hidden;
            Heart2.Visibility = Visibility.Visible;
            
        }

    void Rolout()
        {
            Heart2.Visibility = Visibility.Hidden;
            Heart1.Visibility = Visibility.Visible;            
        }



        public MainWindow()
        {
            InitializeComponent();
            MouseDown += Down_heart;
            WindowHeart1.MouseLeftButtonDown += (o, e) => DragMove(); // Przenoszenie okna
        }

        private void Window_deactivate(object sender, EventArgs e)
        {
            Topmost = true; // Always on top
        }


        private void Down_heart(object sender, MouseButtonEventArgs e)
        {
            Rolover();
            if (e.ClickCount == 2)
            {
                int code = 0;
                Environment.Exit(code); // Zamykanie
            }
        }

        private void Up_heart(object sender, MouseButtonEventArgs e)
        {
            Rolout();
        }        
       
        private void Up_heart(object sender, MouseEventArgs e)
        {
            Rolout();
        }
    }
}
