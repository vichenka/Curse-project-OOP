using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
 public   class TestGen
    {
        public string name;
        public static string querydelete = "delete from [TEST] where [AUTHOR] = @author; ";
        public static string queryinsert = "insert into [TEST] ([NAME_TEST],[AUTHOR]) values (@name, @author);";
      
        public List<Question> q;
        public List<ResultGen> r;

        public TestGen(string s, List<Question> w, List<ResultGen> e)
        {
            name = s;
            q = w;
            r = e;
        }

        public TestGen()
        { }

        public static int GetLastId()
        {
            try
            {
                int i = 0;
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [TEST]", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i = (int)dr["ID"];
                }

                return i;
            }
            catch (Exception Ex)
            {
                System.Windows.MessageBox.Show(Ex.Message);
                return 0;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }
     
        static public void InsertTest(TestGen t) 
        {
            try
            {
                var sql_con = DB.Get_DB_Connection(); 
                SqlCommand cmd2 = new SqlCommand(queryinsert, sql_con);
                cmd2.Parameters.AddWithValue("@author", User.login);
                cmd2.Parameters.AddWithValue("@name",t.name );
                cmd2.ExecuteNonQuery();
                ResultGen.InsertResult(t.r);
                Question.InsertQuestion(t.q);
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

        public static List<TestGen> GetListUserTest()
        {
            try
            {
                List<TestGen> listtest = new List<TestGen>();
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [TEST];", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if ("admin" != (string)dr["AUTHOR"])
                    {
                        TestGen er = new TestGen((string)dr["NAME_TEST"], Question.GetListQuestionByIdTest((int)dr["ID"]), ResultGen.GetListResultGenByIdTest((int)dr["ID"]));
                        listtest.Add(er); 
                    }
                } 
                return listtest;
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

        public static int GetIdTestByName(string name)
        {
            try
            {
                int t=0;
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [TEST];", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (name==(string)dr["NAME_TEST"])
                    {
                        t = (int)dr["ID"];
                        break;
                    }
                } 
                return t;
            }
            catch (Exception Ex)
            {
               MessageBox.Show(Ex.Message);
                return 0;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }

        public static TestGen GetTestGenByIdTest(int id)
        {
            try
            {
                TestGen t = new TestGen(); 
                var sqlC = DB.Get_DB_Connection();
                var tbl = DB.Get_DataTable("select * from [TEST] where [ID]="+id+"; ");
                t.name = (string)tbl.Rows[0]["NAME_TEST"];
                t.q = Question.GetListQuestionByIdTest(id);
                t.r = ResultGen.GetListResultGenByIdTest(id); 

                return t;
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
