using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public static class User
    {
      
        public static int id;
        public static string login;
       

        public static string querydelete = "delete from [USER] where [LOGIN] = @login; ";
        public static string querydelete2 = "delete from [TEST] where [AUTHOR] = @login; ";
 
        public static void DeleteUser(string lgn)
        {
            try
            {
                if (lgn == "admin" )
                {
                    System.Windows.MessageBox.Show("You can't delete a reserved user");
                }
                else
                {
                    int i = 0;
                    var sql_con = DB.Get_DB_Connection(); 
                    SqlCommand cmd = new SqlCommand("select * from [TEST] where [AUTHOR] = @login", sql_con);
                    cmd.Parameters.AddWithValue("@login", lgn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    { 
                        i = (int)dr["ID"];
                        Question.DeleteQuestionByIdTest(i);
                        ResultGen.DeleteResultByIdTest(i);
                    } 

                    SqlCommand sqlCmd2 = new SqlCommand(querydelete2, sql_con);
                    sqlCmd2.Parameters.AddWithValue("@login", lgn);
                    sqlCmd2.ExecuteNonQuery();
                    SqlCommand sqlCmd = new SqlCommand(querydelete, sql_con);
                    sqlCmd.Parameters.AddWithValue("@login", lgn);
                    sqlCmd.ExecuteNonQuery();
                } 
            }
            catch (Exception Ex)
            {
                System.Windows.MessageBox.Show(Ex.Message);

            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }

        public static List<string> GetListLogin()
        {
            try
            {
                List<string> res = new List<string>();
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [USER] ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    res.Add((string)dr["LOGIN"]); 
                } 
                return res;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }

        public static string GetNameUserByTestId(int id)
        {
            string name = "";
            try
            { 
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [TEST] where [ID]="+id, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (string)dr[2];
                }
                return name;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }

    }
}
