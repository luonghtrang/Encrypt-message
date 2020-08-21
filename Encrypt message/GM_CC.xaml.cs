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
    /// Interaction logic for GM_CC.xaml
    /// </summary>
    public partial class GM_CC : Page
    {
        public GM_CC()
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
                if (key1.IsEmpty())
                {
                    isOkay = false;
                    this.Error("Không thể để trống ô CHÌA KHÓA!");
                    key1.Focus();
                }
                else if (key2.IsEmpty())
                {
                    isOkay = false;
                    this.Error("Không thể để trống ô CHÌA KHÓA!");
                    key2.Focus();
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
                    else if (Convert.ToChar(key1.Text) == Convert.ToChar(key2.Text))
                    {
                        so = 0;
                        t = Convert.ToChar((datatext[i]) - so);
                    }
                    else if (Convert.ToChar(key1.Text) > Convert.ToChar(key2.Text))
                    {
                        so = Convert.ToChar(key1.Text) - Convert.ToChar(key2.Text);
                        t = Convert.ToChar((datatext[i]) - so);
                        if (t < 'A')
                            t = (t + 26);
                    }
                    else if (Convert.ToChar(key1.Text) < Convert.ToChar(key2.Text))
                    {
                        so = Convert.ToChar(key2.Text) - Convert.ToChar(key1.Text);
                        t = Convert.ToChar((datatext[i]) + so);
                        if (t > 'Z')
                            t = t - 26;
                    }

                    temp = Convert.ToChar(t).ToString();
                    output.Text += temp;
                }
            }
        }

        //private void Help_giaimachuchu_Click(object sender, RoutedEventArgs e)
        //{
        //    var Screen = new Help_giaimachuchu();
        //    Screen.ShowDialog();
        //}
    }
}
