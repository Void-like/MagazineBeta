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
using MagazineNegrov.Codes;
using MagazineNegrov.Codes.ItemsShop;
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

        private void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            Items CreateItem = new Items();
            CreateItem.Name = NameBox.Text;

             CreateItem.Cost = CostBox.Text;
              CreateItem.Opisanie = OpisanieBox.Text;
          
            ItemsDB.AddItem(CreateItem);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            TovariListik.ItemsSource = ItemsDB.ItemsList;
        }
    }
}
