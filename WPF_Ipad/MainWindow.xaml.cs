using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Ipad
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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                DragMove();
        }

        private void imgHome_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuMainCenter.Visibility = System.Windows.Visibility.Visible;
            menuMainBottom.Visibility = System.Windows.Visibility.Visible;
            menuCal.Visibility = System.Windows.Visibility.Collapsed;
            menuPaint.Visibility = System.Windows.Visibility.Collapsed;
            bgMain.ImageSource = new BitmapImage(new Uri("Images/Wallpaper.jpg", UriKind.Relative));
        }

        private void imgCal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuMainCenter.Visibility = System.Windows.Visibility.Collapsed;
            menuMainBottom.Visibility = System.Windows.Visibility.Collapsed;
            menuCal.Visibility = System.Windows.Visibility.Visible;
            bgMain.ImageSource = new BitmapImage(new Uri("Images/black_background.jpg", UriKind.Relative));
        }

        private void imgPaint_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuMainCenter.Visibility = System.Windows.Visibility.Collapsed;
            menuMainBottom.Visibility = System.Windows.Visibility.Collapsed;
            menuCal.Visibility = System.Windows.Visibility.Collapsed;
            menuPaint.Visibility = System.Windows.Visibility.Visible;
            bgMain.ImageSource = new BitmapImage(new Uri("Images/Paper.jpg", UriKind.Relative));
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbl.Text += ((Button)sender).Content.ToString();
        }

    }
}
