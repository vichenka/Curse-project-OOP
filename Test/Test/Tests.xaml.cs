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
    /// Логика взаимодействия для Tests.xaml
    /// </summary>
    public partial class Tests : Window
    {
        ListBox test;
        List<TestGen> listgen = new List<TestGen>();
        public Tests()
        {
            InitializeComponent();
            test = (ListBox)FindName("list");
            fl();
        }

        private void fl()
        {
            listgen =  TestGen.GetListUserTest();
            foreach( TestGen t in listgen)
            {
             test.Items.Add(t.name);
            }          
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ind = TestGen.GetIdTestByName(list.SelectedItem.ToString());
            UserTest t = new UserTest(ind);
            t.Show();
            this.Close();
        }

        #region NavigandSelectTest
        private void Image_MouseLeftButtonDown_t1(object sender, MouseButtonEventArgs e)
        {
            UserTest t = new UserTest(1);
            t.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown_t2(object sender, MouseButtonEventArgs e)
        {
            UserTest t = new UserTest(2);
            t.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown_t3(object sender, MouseButtonEventArgs e)
        {
            UserTest t = new UserTest(3);
            t.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown_t4(object sender, MouseButtonEventArgs e)
        {
            UserTest t = new UserTest(4);
            t.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseLeftButtonDown_one(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

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
    }
    #endregion
}
