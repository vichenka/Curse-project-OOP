using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public class ResultGen
    {
        public List<ResultGen> res;
        public static string queryinsert = "insert into [RESULT] ([ID_TEST],[RESULT1], [RESULT2],[TEXT_RESULT]) values (@id, @r1, @r2, @txtresult);";
        public static string querydelete = "delete from [RESULT] where [ID_Test] = @id; ";
        public int i1, i2;
        public string s;

        public ResultGen()
        {

        }
        public ResultGen(int one, int two, string str)
        {
            i1 = one;
            i2 = two;
            s = str;
        }

        public static void DeleteResultByIdTest(int id)
        {
            try
            {
                var sql_con = DB.Get_DB_Connection();
                SqlCommand cmd2 = new SqlCommand(querydelete, sql_con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //clsDB.Close_DB_Connection();
            }
        }

        static public void InsertResult(List<ResultGen> r) 
        {
            try
            {
                for (int i = 0; i < r.Count; i++)
                {
                    var sql_con = DB.Get_DB_Connection();
                    SqlCommand cmd2 = new SqlCommand(queryinsert, sql_con);
                    cmd2.Parameters.AddWithValue("@id", TestGen.GetLastId());
                    cmd2.Parameters.AddWithValue("@r1",r[i].i1);
                    cmd2.Parameters.AddWithValue("@r2", r[i].i2);
                    cmd2.Parameters.AddWithValue("@txtresult", r[i].s);
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //clsDB.Close_DB_Connection();
            }
        }


        public static ResultGen GetResultGenByIdResult(int id)//
        {
            try
            {
                ResultGen rs = new ResultGen();
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [RESULT] where [ID_Result] = " + id + " ; ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ResultGen res = new ResultGen((int)dr["RESULT1"], (int)dr["RESULT2"], (string)dr["TEXT_RESULT"]);
                    rs = res;
                }

                return rs;
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

        public static List<ResultGen> GetListResultGenByIdTest(int id)
        {
            try
            {
                List<ResultGen> rs = new List<ResultGen>();
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [RESULT] where [ID_Test] = " + id + " ; ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ResultGen res = new ResultGen((int)dr["RESULT1"], (int)dr["RESULT2"], (string)dr["TEXT_RESULT"]);
                    rs.Add(res);
                }

                return rs;
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
    

