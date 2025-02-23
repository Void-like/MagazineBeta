using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MagazineNegrov.Codes.ItemsShop
{
    public class Items
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Opisanie { get; set; }
        public BitmapImage image { get; set; }
      public int ID { get; set; }
    }
}
