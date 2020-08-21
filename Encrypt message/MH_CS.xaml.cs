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
    /// Interaction logic for MH_CS.xaml
    /// </summary>
    public partial class MH_CS : Page
    {
        public MH_CS()
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
                else if (somahoa.IsEmpty())
                {
                    isOkay = false;
                    this.Error("Không thể để trống ô THẾ BẰNG SỐ!");
                    somahoa.Focus();
                }
            }

            return isOkay;
        }

        private void Chuyen_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra() == true)
            {
                var dataText = input.Text;
                int so = int.Parse(somahoa.Text);
                int temp = so;

                int s;
                if (so == 1)
                    so = 'A';
                else if (so == 2)
                    so = 'B';
                else if (so == 3)
                    so = 'C';
                else if (so == 4)
                    so = 'D';
                else if (so == 5)
                    so = 'E';
                else if (so == 6)
                    so = 'F';
                else if (so == 7)
                    so = 'G';
                else if (so == 8)
                    so = 'H';
                else if (so == 9)
                    so = 'I';
                else if (so == 10)
                    so = 'J';
                else if (so == 11)
                    so = 'K';
                else if (so == 12)
                    so = 'L';
                else if (so == 13)
                    so = 'M';
                else if (so == 14)
                    so = 'N';
                else if (so == 15)
                    so = 'O';
                else if (so == 16)
                    so = 'P';
                else if (so == 17)
                    so = 'Q';
                else if (so == 18)
                    so = 'R';
                else if (so == 19)
                    so = 'S';
                else if (so == 20)
                    so = 'T';
                else if (so == 21)
                    so = 'U';
                else if (so == 22)
                    so = 'V';
                else if (so == 23)
                    so = 'W';
                else if (so == 24)
                    so = 'X';
                else if (so == 25)
                    so = 'Y';
                else if (so == 26)
                    so = 'Z';


                string phay = "";
                string khoangtrang = "";

                for (int i = 0; i < dataText.Length; i++)
                {
                    int chuoi = Convert.ToChar(dataText[i]);

                    if (Convert.ToChar(dataText[i]) == ' ')
                    {
                        khoangtrang = "-,";
                    }
                    else khoangtrang = "";

                    if (Convert.ToChar(chucanmahoa.Text) == so)
                    {
                        s = 0;
                        if (chuoi == 'A')
                            chuoi = int.Parse("1");
                        else if (chuoi == 'B')
                            chuoi = int.Parse("2");
                        else if (chuoi == 'C')
                            chuoi = int.Parse("3");
                        else if (chuoi == 'D')
                            chuoi = int.Parse("4");
                        else if (chuoi == 'E')
                            chuoi = int.Parse("5");
                        else if (chuoi == 'F')
                            chuoi = int.Parse("6");
                        else if (chuoi == 'G')
                            chuoi = int.Parse("7");
                        else if (chuoi == 'H')
                            chuoi = int.Parse("8");
                        else if (chuoi == 'I')
                            chuoi = int.Parse("9");
                        else if (chuoi == 'J')
                            chuoi = int.Parse("10");
                        else if (chuoi == 'K')
                            chuoi = int.Parse("11");
                        else if (chuoi == 'L')
                            chuoi = int.Parse("12");
                        else if (chuoi == 'M')
                            chuoi = int.Parse("13");
                        else if (chuoi == 'N')
                            chuoi = int.Parse("14");
                        else if (chuoi == 'O')
                            chuoi = int.Parse("15");
                        else if (chuoi == 'P')
                            chuoi = int.Parse("16");
                        else if (chuoi == 'Q')
                            chuoi = int.Parse("17");
                        else if (chuoi == 'R')
                            chuoi = int.Parse("18");
                        else if (chuoi == 'S')
                            chuoi = int.Parse("19");
                        else if (chuoi == 'T')
                            chuoi = int.Parse("20");
                        else if (chuoi == 'U')
                            chuoi = int.Parse("21");
                        else if (chuoi == 'V')
                            chuoi = int.Parse("22");
                        else if (chuoi == 'W')
                            chuoi = int.Parse("23");
                        else if (chuoi == 'X')
                            chuoi = int.Parse("24");
                        else if (chuoi == 'Y')
                            chuoi = int.Parse("25");
                        else if (chuoi == 'Z')
                            chuoi = int.Parse("26");
                        else if (chuoi < 'Z')
                            chuoi = 45;

                        if (i == dataText.Length - 1)
                            phay = "".ToString();
                        else phay = ",".ToString();
                    }
                    else if (Convert.ToChar(chucanmahoa.Text) > so)
                    {
                        s = Convert.ToChar(chucanmahoa.Text) - so;
                        chuoi = chuoi - s;
                        if (chuoi < 'A')
                            chuoi = chuoi + 26;

                        if (chuoi == 'A')
                            chuoi = int.Parse("1");
                        else if (chuoi == 'B')
                            chuoi = int.Parse("2");
                        else if (chuoi == 'C')
                            chuoi = int.Parse("3");
                        else if (chuoi == 'D')
                            chuoi = int.Parse("4");
                        else if (chuoi == 'E')
                            chuoi = int.Parse("5");
                        else if (chuoi == 'F')
                            chuoi = int.Parse("6");
                        else if (chuoi == 'G')
                            chuoi = int.Parse("7");
                        else if (chuoi == 'H')
                            chuoi = int.Parse("8");
                        else if (chuoi == 'I')
                            chuoi = int.Parse("9");
                        else if (chuoi == 'J')
                            chuoi = int.Parse("10");
                        else if (chuoi == 'K')
                            chuoi = int.Parse("11");
                        else if (chuoi == 'L')
                            chuoi = int.Parse("12");
                        else if (chuoi == 'M')
                            chuoi = int.Parse("13");
                        else if (chuoi == 'N')
                            chuoi = int.Parse("14");
                        else if (chuoi == 'O')
                            chuoi = int.Parse("15");
                        else if (chuoi == 'P')
                            chuoi = int.Parse("16");
                        else if (chuoi == 'Q')
                            chuoi = int.Parse("17");
                        else if (chuoi == 'R')
                            chuoi = int.Parse("18");
                        else if (chuoi == 'S')
                            chuoi = int.Parse("19");
                        else if (chuoi == 'T')
                            chuoi = int.Parse("20");
                        else if (chuoi == 'U')
                            chuoi = int.Parse("21");
                        else if (chuoi == 'V')
                            chuoi = int.Parse("22");
                        else if (chuoi == 'W')
                            chuoi = int.Parse("23");
                        else if (chuoi == 'X')
                            chuoi = int.Parse("24");
                        else if (chuoi == 'Y')
                            chuoi = int.Parse("25");
                        else if (chuoi == 'Z')
                            chuoi = int.Parse("26");
                        else if (chuoi < 'Z')
                            chuoi = 45;

                        if (i == dataText.Length - 1)
                            phay = "".ToString();
                        else phay = ",".ToString();
                    }
                    else if (Convert.ToChar(chucanmahoa.Text) < so)
                    {
                        s = so - Convert.ToChar(chucanmahoa.Text);
                        chuoi = chuoi + s;
                        if (chuoi > 'Z')
                            chuoi = chuoi - 26;

                        if (chuoi == 'A')
                            chuoi = int.Parse("1");
                        else if (chuoi == 'B')
                            chuoi = int.Parse("2");
                        else if (chuoi == 'C')
                            chuoi = int.Parse("3");
                        else if (chuoi == 'D')
                            chuoi = int.Parse("4");
                        else if (chuoi == 'E')
                            chuoi = int.Parse("5");
                        else if (chuoi == 'F')
                            chuoi = int.Parse("6");
                        else if (chuoi == 'G')
                            chuoi = int.Parse("7");
                        else if (chuoi == 'H')
                            chuoi = int.Parse("8");
                        else if (chuoi == 'I')
                            chuoi = int.Parse("9");
                        else if (chuoi == 'J')
                            chuoi = int.Parse("10");
                        else if (chuoi == 'K')
                            chuoi = int.Parse("11");
                        else if (chuoi == 'L')
                            chuoi = int.Parse("12");
                        else if (chuoi == 'M')
                            chuoi = int.Parse("13");
                        else if (chuoi == 'N')
                            chuoi = int.Parse("14");
                        else if (chuoi == 'O')
                            chuoi = int.Parse("15");
                        else if (chuoi == 'P')
                            chuoi = int.Parse("16");
                        else if (chuoi == 'Q')
                            chuoi = int.Parse("17");
                        else if (chuoi == 'R')
                            chuoi = int.Parse("18");
                        else if (chuoi == 'S')
                            chuoi = int.Parse("19");
                        else if (chuoi == 'T')
                            chuoi = int.Parse("20");
                        else if (chuoi == 'U')
                            chuoi = int.Parse("21");
                        else if (chuoi == 'V')
                            chuoi = int.Parse("22");
                        else if (chuoi == 'W')
                            chuoi = int.Parse("23");
                        else if (chuoi == 'X')
                            chuoi = int.Parse("24");
                        else if (chuoi == 'Y')
                            chuoi = int.Parse("25");
                        else if (chuoi == 'Z')
                            chuoi = int.Parse("26");
                        else if (chuoi < 'Z')
                            chuoi = 45;


                        if (i == dataText.Length - 1)
                            phay = "".ToString();
                        else phay = ",".ToString();
                    }

                    if (chuoi != 45)
                    {
                        //output.Text += (chuoi.ToString() + ",".ToString() + khoangtrang.ToString());
                        output.Text += (chuoi.ToString() + phay.ToString() + khoangtrang.ToString());
                    }
                    else output.Text += (khoangtrang.ToString());
                }

                chiakhoa.Text = somahoa.Text.ToString() + " = ".ToString() + chucanmahoa.Text.ToString();
            }

        }

        //private void Help_mahoachuso_Click(object sender, RoutedEventArgs e)
        //{
        //    var Screen = new Help_mahoachuso();
        //    Screen.ShowDialog();
        //}
    }
}
