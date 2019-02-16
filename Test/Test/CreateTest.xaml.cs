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
    /// Логика взаимодействия для CreateTest.xaml
    /// </summary>
    public partial class CreateTest : Window
    {
        public List<ResultGen> listResult = new List<ResultGen>();
        public List<Question> listQuestion = new List<Question>();
        public List<Answer> listansw = new List<Answer>();
        int e1 = -100;
        int e2 = -10;
        public CreateTest()
        {
            InitializeComponent();
        }

        public void Create()
        {
            bool f = true;//значит все хорошо question
            bool f2 = true;//все хорошо в ответах
            int j;
            for (int i = 1; i <= 5; i++)
            {
                if (f)
                {
                    listansw.Clear();
                    for (j = 1; j <= 3; j++)
                    {
                        if (f2)
                        {
                            string s1 = Convert.ToString(i);
                            string s2 = Convert.ToString(j);
                            TextBox q = (TextBox)FindName("a" + s1 + s2);
                            string s3 = Convert.ToString(i);
                            string s4 = Convert.ToString(j);
                            TextBox qq = (TextBox)FindName("txt" + s3 + s4);
                            if (qq.Text == "" || q.Text == "")
                            {
                                MessageBox.Show("not fill answer or point");
                                listansw.Clear();
                                f2 = false;
                                break;
                            }
                            else
                            {
                                listansw.Add(new Answer(qq.Text, Convert.ToInt32(q.Text)));
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    List<Answer> aqs = new List<Answer>();
                    foreach (Answer a in listansw)
                    {
                        aqs.Add(a);
                    }
                    TextBox qe = (TextBox)FindName("q" + i);
                    if (qe.Text == "")
                    {
                        MessageBox.Show("not fill question");
                        listQuestion.Clear();
                        f = false;
                        break;
                    }
                    else
                    {
                        Question qq = new Question(qe.Text, aqs);
                        listQuestion.Add(qq);
                    }
                }
                else
                {
                    break;
                }
            }  
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtresult.Text == "" || i1.Text == "" || i2.Text == "")
            {
                MessageBox.Show("Not all fields are filled!");
            }
            else
            {
                //int r = Convert.ToInt32(i2.Text);
                e1 = Convert.ToInt32(i1.Text);
                if (e2==-10)
                {

                    listResult.Add(new ResultGen(Convert.ToInt32(i1.Text), Convert.ToInt32(i2.Text), txtresult.Text));
                    e2 = Convert.ToInt32(i2.Text);
                    #region clean
                    txtresult.Text = "";
                    i1.Text = "";
                    i2.Text = "";
                    #endregion
                }
                else
                {
                if (e1 != e2+1)
                {
                    MessageBox.Show("input correct result's point");
                }
                else
                {

                    listResult.Add(new ResultGen(Convert.ToInt32(i1.Text), Convert.ToInt32(i2.Text), txtresult.Text));
                    e2 = Convert.ToInt32(i2.Text);
                    #region clean
                    txtresult.Text = "";
                    i1.Text = "";
                    i2.Text = "";
                    #endregion
                }

                }
            }
          
         
        }

        private void ButtomLog_Click(object sender, RoutedEventArgs e)
        {
            Create();
            if (listResult.Count == 0 || listQuestion.Count == 0) 
            {
                MessageBox.Show("Not all fields are filled!");
            }
            else
            { 
                TestGen t = new TestGen(name.Text, listQuestion, listResult);
                TestGen.InsertTest(t);
                 #region clean
                txtresult.Text = "";
                i1.Text = "";
                i2.Text = "";
                name.Text = "";
                q1.Text = "";
                q2.Text = "";
                q3.Text = "";
                q4.Text = "";
                q5.Text = "";
                txt11.Text = "";
                txt12.Text = "";
                txt13.Text = "";
                txt21.Text = "";
                txt22.Text = "";
                txt23.Text = "";
                txt31.Text = "";
                txt32.Text = "";
                txt33.Text = "";
                txt41.Text = "";
                txt42.Text = "";
                txt43.Text = "";
                txt51.Text = "";
                txt52.Text = "";
                txt53.Text = "";
                a11.Text = "";
                a12.Text = "";
                a13.Text = "";
                a21.Text = "";
                a22.Text = "";
                a23.Text = "";
                a31.Text = "";
                a32.Text = "";
                a33.Text = "";
                a41.Text = "";
                a42.Text = "";
                a43.Text = "";
                a51.Text = "";
                a52.Text = "";
                a53.Text = "";
                txtresult.Text = "";
                i1.Text = "";
                i2.Text = "";


                #endregion
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

        #region valid
        private void a11_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
