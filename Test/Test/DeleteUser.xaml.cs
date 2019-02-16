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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для DeleteUser.xaml
    /// </summary>
    public partial class DeleteUser : Window
    {
        public List<string> listLogin = new List<string>();
        public DeleteUser()
        {
            InitializeComponent();
            Fill();
        }

        public void Fill()
        {
            listLogin.Clear();
            listLogin = User.GetListLogin();
            list.ItemsSource = null;
            list.ItemsSource = listLogin;
        }

        private void ButtomLog_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItems.ToString() == "") { }
            else
            {
                string s = listLogin[list.SelectedIndex];
                User.DeleteUser(s);
                Fill();
            }
        }

        #region Navig
        private void Image_MouseLeftButtonDown_two(object sender, MouseButtonEventArgs e)
        {
            if (User.login == "admin")
            {
                MenuAdmin a = new MenuAdmin();
                a.Show();
                this.Close();
            }
            else
            {
                Menu m = new Menu();
                m.Show();
                this.Close();
            }
        }

        private void Image_MouseLeftButtonDown_one(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
     #endregion
}
