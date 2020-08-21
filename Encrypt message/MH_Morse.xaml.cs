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
    /// Interaction logic for MH_Morse.xaml
    /// </summary>
    public partial class MH_Morse : Page
    {
        public MH_Morse()
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

            return isOkay;
        }

        private void Chuyen_Click(object sender, RoutedEventArgs e)
        {
            var datatext = input.Text;
            string temp = "";
            string ngatchu = " ; ".ToString();

            for (int i = 0; i < datatext.Length;i++)
            {
                if (datatext[i] == ' ')
                    temp = " | ".ToString();
                else if (datatext[i] == 'A')
                    temp = "._".ToString();
                else if (datatext[i] == 'B')
                    temp = "_...".ToString();
                else if (datatext[i] == 'C')
                    temp = "_._.".ToString();
                else if (datatext[i] == 'D')
                    temp = "_..".ToString();
                else if (datatext[i] == 'E')
                    temp = ".".ToString();
                else if (datatext[i] == 'F')
                    temp = ".._.".ToString();
                else if (datatext[i] == 'G')
                    temp = "_ _.".ToString();
                else if (datatext[i] == 'H')
                    temp = "....".ToString();
                else if (datatext[i] == 'I')
                    temp = "..".ToString();
                else if (datatext[i] == 'J')
                    temp = "._ _ _".ToString();
                else if (datatext[i] == 'K')
                    temp = "_._".ToString();
                else if (datatext[i] == 'L')
                    temp = "._..".ToString();
                else if (datatext[i] == 'M')
                    temp = "_ _".ToString();
                else if (datatext[i] == 'N')
                    temp = "._".ToString();
                else if (datatext[i] == 'O')
                    temp = "_ _ _".ToString();
                else if (datatext[i] == 'P')
                    temp = "._ _.".ToString();
                else if (datatext[i] == 'Q')
                    temp = "_ _._".ToString();
                else if (datatext[i] == 'R')
                    temp = "._.".ToString();
                else if (datatext[i] == 'S')
                    temp = "...".ToString();
                else if (datatext[i] == 'T')
                    temp = "_".ToString();
                else if (datatext[i] == 'U')
                    temp = ".._".ToString();
                else if (datatext[i] == 'V')
                    temp = "..._".ToString();
                else if (datatext[i] == 'W')
                    temp = "._ _".ToString();
                else if (datatext[i] == 'X')
                    temp = "_.._".ToString();
                else if (datatext[i] == 'Y')
                    temp = "_._ _".ToString();
                else if (datatext[i] == 'Z')
                    temp = "_ _..".ToString();
                else if (datatext[i] == '1')
                    temp = ". _ _ _ _".ToString();
                else if (datatext[i] == '2')
                    temp = ".. _ _ _".ToString();
                else if (datatext[i] == '3')
                    temp = "..._ _".ToString();
                else if (datatext[i] == '4')
                    temp = "...._".ToString();
                else if (datatext[i] == '5')
                    temp = ".....".ToString();
                else if (datatext[i] == '6')
                    temp = "_....".ToString();
                else if (datatext[i] == '7')
                    temp = "_ _...".ToString();
                else if (datatext[i] == '8')
                    temp = "_ _ _..".ToString();
                else if (datatext[i] == '9')
                    temp = "_ _ _ _.".ToString();
                else if (datatext[i] == '0')
                    temp = "_ _ _ _ _".ToString();



                output.Text = output.Text + (temp + ngatchu);
            }


        }
    }
}
