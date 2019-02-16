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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        TextBox a;
        public Login()
        {
            InitializeComponent();
            a = (TextBox)FindName("psw");
           
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
        #endregion

        private void ButtomReg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtomLog_Click(object sender, RoutedEventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(Metadata.ConnectionString.defaultString))
                {
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="E:\РАБОЧЕЕ\2 курс 2 сем\КУРСАЧ\МОЙ РАБОЧИЙ\MyTEST\Test\Test\DB.mdf";Integrated Security=True; MultipleActiveResultSets=True
                using (SqlCommand cmd = new SqlCommand("PswValid", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Login", login.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordBox.Password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                            Menu b = new Menu();
                                    b.Show();
                            Close();
                        }
                        else
                            {
                             MessageBox.Show("Login or password is incorrect."); 
                        }
                        }
                        conn.Close();
                    }
                }

            
            //SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.Constr);
            //    //@"Data Source=DESKTOP-GGFT0KG\SQLEXPRESS;AttachDbFilename= Initial Catalog = KP_TEST; Integrated Security=True;");
            //try {
            //    if (sqlCon.State == ConnectionState.Closed)
            //        sqlCon.Open();
            //    String querty = "SELECT COUNT(1) FROM [USER] WHERE LOGIN=@LOGIN AND PASSWORD=@PASSWORD";
            //    SqlCommand sqlCmd = new SqlCommand(querty, sqlCon);
            //    sqlCmd.CommandType = CommandType.Text;
            //    sqlCmd.Parameters.AddWithValue("@LOGIN", login.Text);
            //    sqlCmd.Parameters.AddWithValue("@PASSWORD", Hashkod.Hash((Convert.ToString(passwordBox.Password))));
            //    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            //    DataTable table = new DataTable(); 
            //    if (count == 1)
            //    {
            //        SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP(1) * from [USER] where [LOGIN] like '" + login.Text + "'", sqlCon);
            //        adapter.Fill(table);
            //        int access = (int)table.Rows[0]["ACCESS"];
            //        if (access == 1)
            //        {
            //            MenuAdmin bb = new MenuAdmin();
            //            bb.Show();
            //            User.login = login.Text;
            //            this.Close();
            //        }
            //        else
            //        {
            //            Menu b = new Menu();
            //            b.Show();
            //            User.login = login.Text;
            //            this.Close();
            //        }
            //    }
            //    else { MessageBox.Show("Login or password is incorrect."); }

        }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally {
            //    sqlCon.Close();
            //}
       // }
    }
}
