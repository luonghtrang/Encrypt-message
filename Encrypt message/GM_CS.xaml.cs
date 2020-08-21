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
    /// Interaction logic for GM_CS.xaml
    /// </summary>
    public partial class GM_CS : Page
    {
        public GM_CS()
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
                string _stringcut = input.Text;
                string[] tokens = _stringcut.Split(new string[]
                    {
                    ","
                    }, StringSplitOptions.None);

                int chuoi = 0; ;
                int so = int.Parse(key1.Text);
                string temp;
                int t = 0;
                string key11 = "";

                if (so == 1)
                    key11 = "A";
                else if (so == 2)
                    key11 = "B";
                else if (so == 3)
                    key11 = "C";
                else if (so == 4)
                    key11 = "D";
                else if (so == 5)
                    key11 = "E";
                else if (so == 6)
                    key11 = "F";
                else if (so == 7)
                    key11 = "G";
                else if (so == 8)
                    key11 = "H";
                else if (so == 9)
                    key11 = "I";
                else if (so == 10)
                    key11 = "J";
                else if (so == 11)
                    key11 = "K";
                else if (so == 12)
                    key11 = "L";
                else if (so == 13)
                    key11 = "M";
                else if (so == 14)
                    key11 = "N";
                else if (so == 15)
                    key11 = "O";
                else if (so == 16)
                    key11 = "P";
                else if (so == 17)
                    key11 = "Q";
                else if (so == 18)
                    key11 = "R";
                else if (so == 19)
                    key11 = "S";
                else if (so == 20)
                    key11 = "T";
                else if (so == 21)
                    key11 = "U";
                else if (so == 22)
                    key11 = "V";
                else if (so == 23)
                    key11 = "W";
                else if (so == 24)
                    key11 = "X";
                else if (so == 25)
                    key11 = "Y";
                else if (so == 26)
                    key11 = "Z";

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] == "1")
                        chuoi = 65;
                    else if (tokens[i] == "2")
                        chuoi = 66;
                    else if (tokens[i] == "3")
                        chuoi = 67;
                    else if (tokens[i] == "4")
                        chuoi = 68;
                    else if (tokens[i] == "5")
                        chuoi = 69;
                    else if (tokens[i] == "6")
                        chuoi = 70;
                    else if (tokens[i] == "7")
                        chuoi = 71;
                    else if (tokens[i] == "8")
                        chuoi = 72;
                    else if (tokens[i] == "9")
                        chuoi = 73;
                    else if (tokens[i] == "10")
                        chuoi = 74;
                    else if (tokens[i] == "11")
                        chuoi = 75;
                    else if (tokens[i] == "12")
                        chuoi = 76;
                    else if (tokens[i] == "13")
                        chuoi = 77;
                    else if (tokens[i] == "14")
                        chuoi = 78;
                    else if (tokens[i] == "15")
                        chuoi = 79;
                    else if (tokens[i] == "16")
                        chuoi = 80;
                    else if (tokens[i] == "17")
                        chuoi = 81;
                    else if (tokens[i] == "18")
                        chuoi = 82;
                    else if (tokens[i] == "19")
                        chuoi = 83;
                    else if (tokens[i] == "20")
                        chuoi = 84;
                    else if (tokens[i] == "21")
                        chuoi = 85;
                    else if (tokens[i] == "22")
                        chuoi = 86;
                    else if (tokens[i] == "23")
                        chuoi = 87;
                    else if (tokens[i] == "24")
                        chuoi = 88;
                    else if (tokens[i] == "25")
                        chuoi = 89;
                    else if (tokens[i] == "26")
                        chuoi = 90;

                    if (tokens[i] == "-" || tokens[i] == " " || tokens[i] == "_") //chuoi = tokens[i];
                    {
                        t = 32;
                    }
                    else if (Convert.ToChar(key11) == Convert.ToChar(key2.Text))
                    {
                        so = 0;
                        t = chuoi - so;
                    }
                    else if (Convert.ToChar(key11) > Convert.ToChar(key2.Text))
                    {
                        so = Convert.ToChar(key11) - Convert.ToChar(key2.Text);
                        t = chuoi - so;
                        if (t < 'A')
                            t = (t + 26);
                    }
                    else if (Convert.ToChar(key11) < Convert.ToChar(key2.Text))
                    {
                        so = Convert.ToChar(key2.Text) - Convert.ToChar(key11);
                        t = chuoi + so;//
                        if (t > 'Z')
                            t = t - 26;
                    }

                    temp = Convert.ToChar(t).ToString();
                    output.Text += temp;

                }
            }

        }

        //private void Help_giaimachuso_Click(object sender, RoutedEventArgs e)
        //{
        //    var Screen = new Help_giaimachuso();
        //    Screen.ShowDialog();
        //}
    }
}
