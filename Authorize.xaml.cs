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

namespace compcomp
{
    /// <summary>
    /// Логика взаимодействия для Authorize.xaml
    /// </summary>
    public partial class Authorize : Window
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "agata")
            {
                if (textBox2.Text == "1234")
                {
                    if (captchaTextBox.Text == captchaGenTextBox.Text)
                    {
                        Cabinet cabinet = new Cabinet();
                        cabinet.Show();
                    }
                    else MessageBox.Show("Вы неправильно ввели Captcha, пожалуйста, попробуйте еще раз!");
                }
                else
                    MessageBox.Show("Неправильный логин или пароль, попробуйте снова!");
            }
            else MessageBox.Show("Неправильный логин или пароль, попробуйте снова!");
        }
        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = "";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }

            if (captchaGenTextBox.Text != "")
            {
                captchaGenTextBox.Text = null;
            }

            captchaGenTextBox.Text = pwd;
        }
    }
}
