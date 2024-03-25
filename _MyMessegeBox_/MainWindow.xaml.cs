using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace _MyMessegeBox_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            MovementButton();
        }

        async void MovementButton()
        {
            double x = 100;
            double y = 0;
            double g = 0;
            ButtonStop.Opacity = g;
            while (x < 600)
            {
                x++;
                await Task.Delay(1);
                Canvas.SetLeft(ButtonStop, x);
                g += 0.005;
                ButtonStop.Opacity = g;
        }
            while (x > 0)
            {
                x--;
                await Task.Delay(1);
                Canvas.SetLeft(ButtonStop, x);
                if (x < 500 && x > 300)
                {
                    g -= 0.01;
                    ButtonStop.Opacity = g;
                }
                else
                {
                    g += 0.006;
                    ButtonStop.Opacity = g;
                }
                   
            }
            while (x < 800 && y < 410)
            {
                x++;
                y++;
                await Task.Delay(1);
                Canvas.SetLeft(ButtonStop, x);
                Canvas.SetTop(ButtonStop, x);
           }
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

