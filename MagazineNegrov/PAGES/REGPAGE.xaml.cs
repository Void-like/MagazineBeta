using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using MagazineNegrov.Codes;



namespace MagazineNegrov.PAGES
{
 
    /// <summary>
    /// Логика взаимодействия для REGPAGE.xaml
    /// </summary>
    public partial class REGPAGE : Page
    {
    

        public REGPAGE()
        {
            InitializeComponent();
        }



        private void RegTextBox_Click(object sender, RoutedEventArgs e)
        {
            int errors = 0;


            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string password2 = Password2TextBox.Text;
            string email = EmailTextBox.Text;
            User NewUser = new User();
            NewUser.Name = login;
            NewUser.Email = email;
            NewUser.Password = password;
            NewUser.Id = UserDB.Sigmausers.Count;



            if (login.Length > 10)
            {
                LoginTextBox.ToolTip = "Ты ахуел  длинный логин";
                LoginTextBox.Background = Brushes.DarkRed;
                ++errors;
            }
            else
            {
                LoginTextBox.Background = Brushes.LimeGreen;


            }
            if (password.Length > 10)
            {
                PasswordTextBox.ToolTip = "Ты ахуел  длинный пароль";
                PasswordTextBox.Background = Brushes.DarkRed;
                ++errors;
            }
            else
            {

                LoginTextBox.ToolTip = Brushes.LimeGreen;


            }
            if (4 > password.Length)
            {
                PasswordTextBox.ToolTip = "Ты ахуел  короткий пароль";
                PasswordTextBox.Background = Brushes.DarkRed;
                ++errors;
            }
            else
            {

                PasswordTextBox.Background = Brushes.LimeGreen;
            }
            if (password != password2)
            {

                PasswordTextBox.ToolTip = "КАКОЙ ТЫ ТУПОЙ НЕ МОЖЕШЬ ДВА ПАРОЛЯ ВМЕСТЕ НАПИСАТЬ ААААААААА";
                PasswordTextBox.Background = Brushes.DarkRed;
                Password2TextBox.ToolTip = "КАКОЙ ТЫ ТУПОЙ НЕ МОЖЕШЬ ДВА ПАРОЛЯ ВМЕСТЕ НАПИСАТЬ ААААААААА";
                Password2TextBox.Background = Brushes.DarkRed;
                ++errors;
            }
            else
            {
                PasswordTextBox.Background = Brushes.LimeGreen;

                Password2TextBox.Background = Brushes.LimeGreen;
            }
            if (email.Contains("@") || email.Contains("."))
            {
                EmailTextBox.Background = Brushes.LimeGreen;
            }
            else
            {
                EmailTextBox.ToolTip = "я молчу это пиздец";
                EmailTextBox.Background = Brushes.DarkRed;
                ++errors;
            }
            if (errors == 0)
            {
                LoginTextBox.ToolTip = "";
                LoginTextBox.Background = Brushes.Transparent;

                PasswordTextBox.ToolTip = "";
                PasswordTextBox.Background = Brushes.Transparent;
                Password2TextBox.ToolTip = "";
                Password2TextBox.Background = Brushes.Transparent;
                EmailTextBox.ToolTip = "";
                EmailTextBox.Background = Brushes.Transparent;
                MessageBox.Show("ЗБС твои данные мои228");


                UserDB.AddUser(NewUser);
               
             
                
            }
           
        }
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xzlol.Content = new LOGPAGE();
        }

        private void xzlol_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void UsersList_Loaded(object sender, RoutedEventArgs e)
        {
            UsersList.ItemsSource = UserDB.Sigmausers;


        }
    }
       
}

