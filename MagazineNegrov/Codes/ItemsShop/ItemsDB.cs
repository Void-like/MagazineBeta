using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagazineNegrov.Codes.ItemsShop
{
    internal class ItemsDB
    {
        public static BindingList<Items> ItemsList = new BindingList<Items>();

        public static BindingList<Items> Korzina = new BindingList<Items>();


        public static void AddItem(Items item)
        {



            ItemsList.Add(item);
            MessageBox.Show("товар добавлен");






        }
        public static void AddItemInKorzina(Items item)
        {



            Korzina.Add(item);
            MessageBox.Show("товар добавлен в корзину");






        }
    }
}
