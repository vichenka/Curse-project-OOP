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
    /// Логика взаимодействия для UserTest.xaml
    /// </summary>
    public partial class UserTest : Window
    {
        static public int index;
        public TestGen tg;
        public int resultAll = 0;
        public UserTest()
        {
            InitializeComponent();
           
        }
        public UserTest(int id)
        {
            InitializeComponent();
            index = id; //ид теста
            FillT();
            Fill();
            FillRb();
            txtauthor.Content = "Author: " + User.GetNameUserByTestId(id);
        }

        public void FillT()
        {
            tg = TestGen.GetTestGenByIdTest(index);
        }
        public void Fill()
        {
            int ii = 1;
            var listq = Question.GetListQuestionByIdTest(index);
            foreach(Question que in listq)
            {
                Label l = (Label)FindName("q" + ii);
                l.Content = que.text;//index = id test
                ii++;
            }

        }
             
        public void FillRb()
        {
            
            int id_q = Question.GetFirstIdQuestionByTestId(index);
            for (int i =0; i < 5; i++)
            {
                int itr = id_q + i;
                var a = Answer.GetListAnswerByIdQuestion(itr);

                int u = 1; 
                foreach (Answer aa in a )
                {
                    string s1,s2;
                    s1 = Convert.ToString(i+1);
                    s2 = Convert.ToString(u);
                    RadioButton rb = (RadioButton)FindName("rb" + s1 + s2);
                    rb.Content = aa.anstext;
                  
                    u++;
                }
                    
            }
        }

        private void ButtomLog_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            int count = 0;
            List<RadioButton> rlist = new List<RadioButton>();
            for (int i = 0; i < 5; i++)
            { 
                for(int j = 1; j <=3; j++)
                {
                    string s1, s2;
                    s1 = Convert.ToString(i+1);
                    s2 = Convert.ToString(j);
                    RadioButton rb = (RadioButton)FindName("rb" + s1 + s2);
                   if((bool)rb.IsChecked)
                    {
                        count++;
                        rlist.Add(rb);
                    }  
                }

            }
            if (count != 5) { MessageBox.Show("Not all fields are filled!"); }
            else
            {
                int y = 0;
                foreach (Question quest in tg.q)//tg-TestGen
                {
                    flag = false;
                    foreach (Answer qansw in quest.answ)
                    {
                        if ((string)rlist[y].Content == qansw.anstext)
                        {
                            y++;
                            flag = true;
                            resultAll += qansw.bal;
                            break;

                        }

                        if (flag == true)
                        {
                            break;
                        }

                    }
                }
                var list_res_gen = ResultGen.GetListResultGenByIdTest(index);
                foreach (ResultGen resgen in list_res_gen)
                {
                    if (resultAll>=resgen.i1 && resultAll<=resgen.i2)
                    {
                        Result r = new Result(resgen);
                        r.Show();
                        Close();
                    }
                }
                
            }
        }
         
        #region Navig
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
        #endregion
 
    }
}
