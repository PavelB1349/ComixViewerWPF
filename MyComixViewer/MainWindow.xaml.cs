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

namespace MyComixViewer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnP1_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage1.Source;
        }
        private void BtnP2_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage2.Source;
        }
        private void BtnP3_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage3.Source;
        }
        private void BtnP4_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage4.Source;
        }
        private void BtnP5_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage5.Source;
        }
        private void BtnP6_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage6.Source;
        }
        private void BtnP7_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage7.Source;
        }
        private void BtnP8_Click(object sender, RoutedEventArgs e)
        {
            imgMain.Source = imgPage8.Source;
        }

        private void SldSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            imgMain.Width = sSize.Value;
        }
    }
}
