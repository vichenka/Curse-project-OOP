using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{
    public class TestView
    {
        public static int Count () //подсчёт юзерских тестов
        {
            try
            {
                var sqlC = DB.Get_DB_Connection();
                var tbl = DB.Get_DataTable("select count (*) from [TEST] where AUTHOR != 'admin'; ");
                int i = (int)tbl.Rows[0][0];
                return i;
            }
            catch {
                return 0;
            }

            finally
            {
                DB.Close_DB_Connection();
            } 
        }

        public static string Name(int t) //имя юзерских тестов
        {
            try
            {
                var sqlC = DB.Get_DB_Connection();
                var tbl = DB.Get_DataTable("select * from [TEST] where AUTHOR != 'admin'; ");
               string s = (string)tbl.Rows[t]["NAME_TEST"];
                return s;
            }
            catch
            {
                return null;
            }

            finally
            {
                DB.Close_DB_Connection();
            }
        }
    } 

}
