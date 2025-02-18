using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Data;

namespace MagazineNegrov.Codes
{
    public class UserDB
    {

       public static BindingList<User> Sigmausers = new BindingList<User>();
        

        public static void AddUser(User user)
        {



            Sigmausers.Add(user);
            MessageBox.Show("ЗБС твои данные мои");






        }
    }
}

      

        
  
  

