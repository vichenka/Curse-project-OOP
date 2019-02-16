using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public class Answer
    {
        public string anstext;
        public int bal;
        public static string queryinsert = "insert into [POINT] ([ID_Quest],[ANSWER], [POINT]) values (@id, @answer,@point);";
        public static string querydelete = "delete from [POINT] where [ID_Quest] = @id; ";
        public Answer(string a, int b)
        {
            anstext = a;
            bal = b;
        }


        public Answer()
        {

        }


        public static void DeleteAnswerByIdQuestion(int id)
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


        //public static int GetLastId()
        //{
        //    try
        //    {
        //        int i = 0;
        //        var conn = DB.Get_DB_Connection();
        //        SqlCommand cmd = new SqlCommand("select * from [POINT]", conn);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            i = (int)dr["ID_ANSWER"];
        //        }

        //        return i;
        //    }
        //    catch (Exception Ex)
        //    {
        //        System.Windows.MessageBox.Show(Ex.Message);
        //        return 0;
        //    }

        //    finally
        //    {
        //        DB.Close_DB_Connection();
        //    }
        //}


        static public void InsertAnswer(List<Answer> r) 
        {
            try
            {
                for (int i = 0; i < r.Count; i++)
                {
                    var sql_con = DB.Get_DB_Connection();
                    SqlCommand cmd2 = new SqlCommand(queryinsert, sql_con);
                    cmd2.Parameters.AddWithValue("@id",Question.GetLastId());
                    cmd2.Parameters.AddWithValue("@answer", r[i].anstext);
                    cmd2.Parameters.AddWithValue("@point", r[i].bal);
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

        public static Answer GetAnswerByIdAnswer(int id)//конкртеный 1 ответ ( 1 радиобат)
        {//берём баллы и сам ответ
            try
            {
                Answer answer = new Answer();
             
                var sqlC = DB.Get_DB_Connection();
                var tbl = DB.Get_DataTable("select * from [POINT] where [ID_ANSWER] = " + id + "; ");
                answer.bal = (int)tbl.Rows[(0)]["POINT"];
                answer.anstext = (string)tbl.Rows[(0)]["ANSWER"];

                return answer;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }

        }

        public static List<Answer> GetListAnswerByIdQuestion(int id)
        {//получаем список ответов и баллы за них
            try
            {
                List<Answer> answer = new List<Answer>();                               
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [POINT] where [ID_Quest] = " + id + " ; ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Answer an = new Answer((string)dr["ANSWER"], (int)dr["POINT"]);
                    answer.Add(an); 
                }               
                return answer;
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
