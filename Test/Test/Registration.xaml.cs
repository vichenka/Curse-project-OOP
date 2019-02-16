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
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtomReg_Click(object sender, RoutedEventArgs e)
        {
            if ((textBox.Text).Length > 2 && (textBox.Text).Length < 20 && login.Text != "")
            {
                //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\РАБОЧЕЕ\2 курс 2 сем\КУРСАЧ\MyTEST\Test\Test\DB.mdf';Integrated Security=True"
                SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.Constr);
                try
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    String querty = "SELECT COUNT(1) FROM [USER] WHERE LOGIN=@LOGIN";
                    SqlCommand sqlCmd = new SqlCommand(querty, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@LOGIN", login.Text);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    DataTable table = new DataTable();
                    if (count == 0)
                    {
                        String query = "Insert into [USER] (Login, Password,Access) values (@Login, @Password,@Access)";
                        SqlCommand sqlCmd2 = new SqlCommand(query, sqlCon);
                        sqlCmd2.CommandType = CommandType.Text;
                        sqlCmd2.Parameters.AddWithValue("@Login", login.Text);
                        sqlCmd2.Parameters.AddWithValue("@Password", Hashkod.Hash((Convert.ToString(passwordBox.Password))));
                        sqlCmd2.Parameters.AddWithValue("@Access", "2");
                        sqlCmd2.ExecuteNonQuery();

                        Login Menu = new Login();
                        Menu.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("This login already exists");
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            else {
                try
                {
                    MessageBox.Show("Password langht should be < 20 and > 2 and login can not be empty");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //sqlCon.Close();
                }
            }

        }

        #region navig
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseLeftButtonDown_one(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        #endregion
    }
}
