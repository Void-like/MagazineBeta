using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MagazineNegrov.PAGES
{

    public partial class LOGPAGE : Page
    {

        public LOGPAGE()
        {
         
            InitializeComponent();
        }

        private void RegTextBox_Click(object sender, RoutedEventArgs e)
        {
            xzlol.Content = new REGPAGE();
        }

        private void xzlol_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();

            User Admin = new User();
            Admin.Name = "SIGMADMIN";
           Admin.Password = "22848";
            User LOGuser = new User();
            LOGuser.Name = LoginTextBox.Text;
            LOGuser.Password = PasswordTextBox.Text;
          bool a =  AuthenticateUser(LOGuser.Name, LOGuser.Password);
            if (LOGuser.Name == Admin.Name && LOGuser.Password == Admin.Password)
            {
                xzlol.Content = new SIGMAADMIN();
            }
            else if (a == true)
            {
               xzlol.Content = new SIGMASHOP();
            }
        }
          
           public static bool AuthenticateUser(string login, string password)
        {
            foreach (var user in UserDB.Sigmausers)
            {
                if (user.Name == login && user.Password == password)
                {
                    MessageBox.Show("алло куда ты заходишь?!?!!??!");
              
                    return true;
                }
                else
                {
                    MessageBox.Show("куда мы лезим боже?!?!!??!");
                }
            }
              
                    return false;
                
            
        }

    }
    }
    

