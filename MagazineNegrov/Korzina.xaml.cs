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
using System.Windows.Shapes;
using MagazineNegrov.Codes.ItemsShop;

namespace MagazineNegrov
{
    /// <summary>
    /// Логика взаимодействия для Korzina.xaml
    /// </summary>
    public partial class Korzina : Window
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void tovars_Loaded(object sender, RoutedEventArgs e)
        {
            tovars.ItemsSource = ItemsDB.Korzina;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Korzina window = new Korzina();
           window.Close();
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("ты это не купишь ты бедняк");
        }
    }
}


























