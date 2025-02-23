using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.IO;

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
        public static void SigmaADD(string name, string cost, string opisanie, Items CreateItem, BitmapImage img)
        {

            CreateItem.Name = name;
            CreateItem.Cost = cost;
            CreateItem.Opisanie = opisanie;
            CreateItem.ID = ItemsDB.ItemsList.Count;
            CreateItem.image = img;

            if (CreateItem == null)
            {
                MessageBox.Show("ТЫ ЕБИК?");
            }
            else
            {
                ItemsDB.AddItem(CreateItem);
            }
        }
       
    }
}

