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
using MagazineNegrov.Codes.ItemsShop;


namespace MagazineNegrov.PAGES
{
    /// <summary>
    /// Логика взаимодействия для SIGMASHOP.xaml
    /// </summary>
    public partial class SIGMASHOP : Page
    {
       
        public SIGMASHOP()
        {
            InitializeComponent();
            tovars.ItemsSource = ItemsDB.ItemsList;
             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xzlol.Content = new LOGPAGE(); 
        }

        private void ADDTOKORZINA_Click(object sender, RoutedEventArgs e)
        {
         var button = sender as Button;
            var items = button.DataContext as Items;
            ItemsDB.AddItemInKorzina(items);



         }

        private void OpenKorzina(object sender, RoutedEventArgs e)
        {
          Korzina window = new Korzina();
            window.Show();
        }

        private void xzlol_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void tovars_Loaded(object sender, RoutedEventArgs e)
        {
            
          
        }
    }
}
