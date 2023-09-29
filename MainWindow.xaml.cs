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

namespace _29._09._2023_class_work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void buttonChangeLanguage_Click(object sender, RoutedEventArgs e) {
            butt1.Content = "Кнопка номер один";
            butt2.Content = "Кнопка номер два";
            butt3.Content = "Кнопка номер три";
            butt4.Content = "Кнопка номер чотири";
            butt5.Content = "Кнопка номер п'ять";
            butt6.Content = "Кнопка номер шість";
            textBlock.Text = "Текст у TextBlock";
            image.Source = new BitmapImage(new Uri("ua.txt"));
        }
    }
}
