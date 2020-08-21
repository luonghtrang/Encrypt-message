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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Encrypt_message
{
    /// <summary>
    /// Interaction logic for MH_CC.xaml
    /// </summary>
    public partial class MH_CC : Page
    {
        public MH_CC()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Home _PageHone = new Home();
            this.NavigationService.Navigate(_PageHone);
        }

        private bool kiemtra()
        {
            bool isOkay = true;
            if (input.IsEmpty())
            {
                isOkay = false;
                this.Error("Không thể để trống ô nhập dữ liệu!");
                input.Focus();
            }
            else
            {
                if (chucanmahoa.IsEmpty())
                {
                    isOkay = false;
                    this.Error("Không thể để trống ô CHỮ THAY THẾ!");
                    chucanmahoa.Focus();
                }
                else if (chumahoa.IsEmpty())
                {
                    isOkay = false;
                    this.Error("Không thể để trống ô THẾ BẰNG CHỮ!");
                    chumahoa.Focus();
                }

            }



            return isOkay;
        }

        private void Chuyen_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra() == true)
            {
                var datatext = input.Text;
                string temp;
                int t = 0;
                int so;



                for (int i = 0; i < datatext.Length; i++)
                {
                    if (datatext[i] == ' ')
                    {
                        t = 32;
                    }
                    else if (Convert.ToChar(chucanmahoa.Text) == Convert.ToChar(chumahoa.Text))
                    {
                        so = 0;
                        t = Convert.ToChar((datatext[i]) - so);
                    }
                    else if (Convert.ToChar(chucanmahoa.Text) > Convert.ToChar(chumahoa.Text))
                    {
                        so = Convert.ToChar(chucanmahoa.Text) - Convert.ToChar(chumahoa.Text);
                        t = Convert.ToChar((datatext[i]) - so);
                        if (t < 'A')
                            t = (t + 26);
                    }
                    else if (Convert.ToChar(chucanmahoa.Text) < Convert.ToChar(chumahoa.Text))
                    {
                        so = Convert.ToChar(chumahoa.Text) - Convert.ToChar(chucanmahoa.Text);
                        t = Convert.ToChar((datatext[i]) + so);
                        if (t > 'Z')
                            t = t - 26;
                    }

                    temp = Convert.ToChar(t).ToString();
                    output.Text += temp;

                }
                chiakhoa.Text = chumahoa.Text + " = ".ToString() + chucanmahoa.Text;
            }
        }

        //private void Help_mahoachuchu_Click(object sender, RoutedEventArgs e)
        //{
        //    var Screen = new Help_mahoachuchu();
        //    Screen.ShowDialog();
        //}
    }
}
