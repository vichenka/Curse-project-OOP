using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
   public class Question
    {
        public string text;
        public List<Answer> answ;
        public static string queryinsert = "insert into [QUESTION] ([ID_TEST],[QUESTION]) values (@id, @question);";
        public static string querydelete = "delete from [QUESTION] where [ID_TEST] = @id;";
        public Question(string t, List<Answer> a)
        {
            text = t;
            answ = a;
        }

       public Question()
        {

        }

        public static void DeleteQuestionByIdTest(int id)
        {
            try
            {
                int i = 0;
                var sql_con = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [QUESTION] where [ID_TEST] =" + id , sql_con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i = (int)dr["ID_QUESTION"];
                    Answer.DeleteAnswerByIdQuestion(i);
                }
                 SqlCommand cmd2 = new SqlCommand(querydelete, sql_con);
                 cmd2.Parameters.AddWithValue("@id", id);
                 cmd2.ExecuteNonQuery(); //MultipleActiveResultSets=True
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

        public static int GetLastId()
        {
            try
            {
                int i = 0;
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [QUESTION]", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i = (int)dr["ID_QUESTION"];
                }

                return i;
            }
            catch (Exception Ex)
            {
                System.Windows.MessageBox.Show(Ex.Message);
                return 0;
            }
        }
          
        public static int GetFirstIdQuestionByTestId(int id)
        {
            try
            {
                int ii = 0;
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [QUESTION] where [ID_TEST] = " + id + " ; ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ii = (int)dr["ID_QUESTION"];
                    break;
                }

                return ii;
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

        static public void InsertQuestion(List<Question> r) 
        {
            try
            {
                for (int i = 0; i < r.Count; i++)
                {
                  
                    var sql_con = DB.Get_DB_Connection();
                    SqlCommand cmd2 = new SqlCommand(queryinsert, sql_con);
                    cmd2.Parameters.AddWithValue("@id", TestGen.GetLastId());
                    cmd2.Parameters.AddWithValue("@question", r[i].text);
                    cmd2.ExecuteNonQuery();
                    Answer.InsertAnswer(r[i].answ); 
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

        public static Question GetQuestionByIdQuestion(int id)
        {
            try
            {//получаем вопрос и ответы к нему
                Question question = new Question();
                var sqlC = DB.Get_DB_Connection();
                var tbl = DB.Get_DataTable("select * from [QUESTION] where [ID_QUESTION]= " + id + "; ");
                question.text = (string)tbl.Rows[(0)]["QUESTION"];
                question.answ = Answer.GetListAnswerByIdQuestion(id);
                return question;
            }
            catch (Exception Ex)
            {
                System.Windows.MessageBox.Show(Ex.Message);
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }

        public static List<Question> GetListQuestionByIdTest(int id)
        {
            try
            {
                List<Question> question = new List<Question>();
                var conn = DB.Get_DB_Connection();
                SqlCommand cmd = new SqlCommand("select * from [QUESTION] where [ID_TEST] = " + id + " ; ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Question q = new Question((string)dr["QUESTION"], Answer.GetListAnswerByIdQuestion((int)dr["ID_QUESTION"]));
                    question.Add(q); 
                }

                return question;
            }
            catch (Exception Ex)
            {
                System.Windows.MessageBox.Show(Ex.Message);
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }
    }

   
}
