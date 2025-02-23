using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using MagazineNegrov.Codes;

using MagazineNegrov.Codes.ItemsShop;
using Microsoft.Win32;
namespace MagazineNegrov.PAGES
{

    /// <summary>
    /// Логика взаимодействия для SIGMAADMIN.xaml
    /// </summary>
    public partial class SIGMAADMIN : Page
    {


        public SIGMAADMIN()
        {
            InitializeComponent();


        }





        private void TovariListik_Loaded(object sender, RoutedEventArgs e)
        {
            TovariListik.ItemsSource = ItemsDB.ItemsList;
        }

        public void Загрузить_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                BitmapImage img = new BitmapImage(new Uri(ofd.FileName));
                tiDAYN.Source = img;
                byte[] imageData = File.ReadAllBytes(ofd.FileName);

            }
            else { MessageBox.Show("капец картинке"); }

        }
    


        
        public void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage img = (BitmapImage)tiDAYN.Source;
           Items CreateItem = new Items();
          
            ItemsDB.SigmaADD(NameBox.Text, CostBox.Text, OpisanieBox.Text, CreateItem,img);

        }
        private void КнопкаСписокТоваров_Click(object sender, RoutedEventArgs e)
        {
            xzlol.Content = new SIGMASHOP();
        }

      
    }
}
