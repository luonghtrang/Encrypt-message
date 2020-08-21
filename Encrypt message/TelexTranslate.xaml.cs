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
    /// Interaction logic for TelexTranslate.xaml
    /// </summary>
    public partial class TelexTranslate : Page
    {
        public TelexTranslate()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Home _PageHone = new Home();
            this.NavigationService.Navigate(_PageHone);
        }

        private void Chuyen_Click(object sender, RoutedEventArgs e)
        {
            var dataText = input.Text;
            string temp = "";
            string ngatchu = " ".ToString();

            for(int i = 0; i<dataText.Length;i++)
            {
                if (dataText[i] == ' ')
                    temp = " ".ToString();
                else if (dataText[i] == 'A' || dataText[i] == 'a')
                    temp = "A".ToString();
                else if (dataText[i] == 'Ă' || dataText[i] == 'ă')
                    temp = "AW".ToString();
                else if (dataText[i] == 'Ắ' || dataText[i] == 'ắ')
                    temp = "AWS".ToString();
                else if (dataText[i] == 'Ằ' || dataText[i] == 'ằ')
                    temp = "AWF".ToString();
                else if (dataText[i] == 'Ẳ' || dataText[i] == 'ẳ')
                    temp = "AWR".ToString();
                else if (dataText[i] == 'Ẵ' || dataText[i] == 'ẵ')
                    temp = "AWX".ToString();
                else if (dataText[i] == 'Ặ' || dataText[i] == 'ặ')
                    temp = "AWJ".ToString();
                else if (dataText[i] == 'Â' || dataText[i] == 'â')
                    temp = "AA".ToString();
                else if (dataText[i] == 'Ấ' || dataText[i] == 'ấ')
                    temp = "AAS".ToString();
                else if (dataText[i] == 'Ầ' || dataText[i] == 'ầ')
                    temp = "AAF".ToString();
                else if (dataText[i] == 'Ẩ' || dataText[i] == 'ẩ')
                    temp = "AAR".ToString();
                else if (dataText[i] == 'Ẫ' || dataText[i] == 'ẫ')
                    temp = "AAX".ToString();
                else if (dataText[i] == 'Ậ' || dataText[i] == 'ậ')
                    temp = "AAJ".ToString();
                else if (dataText[i] == 'Á' || dataText[i] == 'á')
                    temp = "AS".ToString();
                else if (dataText[i] == 'À' || dataText[i] == 'à')
                    temp = "AF".ToString();
                else if (dataText[i] == 'Ạ' || dataText[i] == 'ạ')
                    temp = "AJ".ToString();
                else if (dataText[i] == 'Ả' || dataText[i] == 'ả')
                    temp = "AR".ToString();
                else if (dataText[i] == 'Ã' || dataText[i] == 'ã')
                    temp = "AX".ToString();
                else if (dataText[i] == 'B' || dataText[i] == 'b')
                    temp = "B".ToString();
                else if (dataText[i] == 'C' || dataText[i] == 'c')
                    temp = "C".ToString();
                else if (dataText[i] == 'D' || dataText[i] == 'd')
                    temp = "D".ToString();
                else if (dataText[i] == 'Đ' || dataText[i] == 'đ')
                    temp = "DD".ToString();
                else if (dataText[i] == 'E' || dataText[i] == 'e')
                    temp = "E".ToString();
                else if (dataText[i] == 'É' || dataText[i] == 'é')
                    temp = "ES".ToString();
                else if (dataText[i] == 'È' || dataText[i] == 'è')
                    temp = "EF".ToString();
                else if (dataText[i] == 'Ẻ' || dataText[i] == 'ẻ')
                    temp = "ER".ToString();
                else if (dataText[i] == 'Ẽ' || dataText[i] == 'ẽ')
                    temp = "EX".ToString();
                else if (dataText[i] == 'Ẹ' || dataText[i] == 'ẹ')
                    temp = "EJ".ToString();
                else if (dataText[i] == 'Ê' || dataText[i] == 'ê')
                    temp = "EE".ToString();
                else if (dataText[i] == 'Ế' || dataText[i] == 'ế')
                    temp = "EES".ToString();
                else if (dataText[i] == 'Ề' || dataText[i] == 'ề')
                    temp = "EEF".ToString();
                else if (dataText[i] == 'Ể' || dataText[i] == 'ể')
                    temp = "EER".ToString();
                else if (dataText[i] == 'Ễ' || dataText[i] == 'ễ')
                    temp = "EEX".ToString();
                else if (dataText[i] == 'Ệ' || dataText[i] == 'ệ')
                    temp = "EEJ".ToString();
                else if (dataText[i] == 'F' || dataText[i] == 'f')
                    temp = "F".ToString();
                else if (dataText[i] == 'G' || dataText[i] == 'g')
                    temp = "G".ToString();
                else if (dataText[i] == 'H' || dataText[i] == 'h')
                    temp = "H".ToString();
                else if (dataText[i] == 'I' || dataText[i] == 'i')
                    temp = "I".ToString();
                else if (dataText[i] == 'Í' || dataText[i] == 'í')
                    temp = "IS".ToString();
                else if (dataText[i] == 'Ì' || dataText[i] == 'ì')
                    temp = "IF".ToString();
                else if (dataText[i] == 'Ỉ' || dataText[i] == 'ỉ')
                    temp = "IR".ToString();
                else if (dataText[i] == 'Ĩ' || dataText[i] == 'ĩ')
                    temp = "IX".ToString();
                else if (dataText[i] == 'Ị' || dataText[i] == 'ị')
                    temp = "IJ".ToString();
                else if (dataText[i] == 'K' || dataText[i] == 'k')
                    temp = "K".ToString();
                else if (dataText[i] == 'L' || dataText[i] == 'l')
                    temp = "L".ToString();
                else if (dataText[i] == 'M' || dataText[i] == 'm')
                    temp = "M".ToString();
                else if (dataText[i] == 'N' || dataText[i] == 'n')
                    temp = "N".ToString();
                else if (dataText[i] == 'O' || dataText[i] == 'o')
                    temp = "O".ToString();
                else if (dataText[i] == 'Ó' || dataText[i] == 'ó')
                    temp = "OS".ToString();
                else if (dataText[i] == 'Ò' || dataText[i] == 'ò')
                    temp = "OF".ToString();
                else if (dataText[i] == 'Ỏ' || dataText[i] == 'ỏ')
                    temp = "OR".ToString();
                else if (dataText[i] == 'Õ' || dataText[i] == 'õ')
                    temp = "OX".ToString();
                else if (dataText[i] == 'Ọ' || dataText[i] == 'ọ')
                    temp = "OJ".ToString();
                else if (dataText[i] == 'Ô' || dataText[i] == 'ô')
                    temp = "OO".ToString();
                else if (dataText[i] == 'Ố' || dataText[i] == 'ố')
                    temp = "OOS".ToString();
                else if (dataText[i] == 'Ồ' || dataText[i] == 'ồ')
                    temp = "OOF".ToString();
                else if (dataText[i] == 'Ổ' || dataText[i] == 'ổ')
                    temp = "OOR".ToString();
                else if (dataText[i] == 'Ỗ' || dataText[i] == 'ỗ')
                    temp = "OOX".ToString();
                else if (dataText[i] == 'Ộ' || dataText[i] == 'ộ')
                    temp = "OOJ".ToString();
                else if (dataText[i] == 'Ơ' || dataText[i] == 'ơ')
                    temp = "OW".ToString();
                else if (dataText[i] == 'Ớ' || dataText[i] == 'ớ')
                    temp = "OWS".ToString();
                else if (dataText[i] == 'Ờ' || dataText[i] == 'ờ')
                    temp = "OWF".ToString();
                else if (dataText[i] == 'Ở' || dataText[i] == 'ở')
                    temp = "OWR".ToString();
                else if (dataText[i] == 'Ỡ' || dataText[i] == 'ỡ')
                    temp = "OWX".ToString();
                else if (dataText[i] == 'Ợ' || dataText[i] == 'ợ')
                    temp = "OWJ".ToString();
                else if (dataText[i] == 'P' || dataText[i] == 'p')
                    temp = "P".ToString();
                else if (dataText[i] == 'Q' || dataText[i] == 'q')
                    temp = "Q".ToString();
                else if (dataText[i] == 'R' || dataText[i] == 'r')
                    temp = "R".ToString();
                else if (dataText[i] == 'S' || dataText[i] == 's')
                    temp = "S".ToString();
                else if (dataText[i] == 'T' || dataText[i] == 't')
                    temp = "T".ToString();
                else if (dataText[i] == 'U' || dataText[i] == 'u')
                    temp = "U".ToString();
                else if (dataText[i] == 'Ú' || dataText[i] == 'ú')
                    temp = "US".ToString();
                else if (dataText[i] == 'Ù' || dataText[i] == 'ù')
                    temp = "UF".ToString();
                else if (dataText[i] == 'Ủ' || dataText[i] == 'ủ')
                    temp = "UR".ToString();
                else if (dataText[i] == 'Ũ' || dataText[i] == 'ũ')
                    temp = "UX".ToString();
                else if (dataText[i] == 'Ụ' || dataText[i] == 'ụ')
                    temp = "UJ".ToString();
                else if (dataText[i] == 'Ư' || dataText[i] == 'ư')
                {
                    if (dataText[i + 1] == 'Ơ' || dataText[i + 1] == 'ơ' || dataText[i + 1] == 'Ớ' || dataText[i + 1] == 'ớ' || dataText[i + 1] == 'Ờ' || dataText[i + 1] == 'ờ' || dataText[i + 1] == 'Ở' || dataText[i + 1] == 'ở' || dataText[i + 1] == 'Ỡ'|| dataText[i + 1] == 'ỡ' || dataText[i + 1] == 'Ợ' || dataText[i + 1] == 'ợ')
                        temp = "U".ToString();
                    else temp = "UW".ToString();
                }
                else if (dataText[i] == 'Ứ' || dataText[i] == 'ứ')
                    temp = "UWS".ToString();
                else if (dataText[i] == 'Ừ' || dataText[i] == 'ừ')
                    temp = "UWF".ToString();
                else if (dataText[i] == 'Ử' || dataText[i] == 'ử')
                    temp = "UWR".ToString();
                else if (dataText[i] == 'Ữ' || dataText[i] == 'ữ')
                    temp = "UWX".ToString();
                else if (dataText[i] == 'Ự' || dataText[i] == 'ự')
                    temp = "UWJ".ToString();
                else if (dataText[i] == 'V' || dataText[i] == 'v')
                    temp = "V".ToString();
                else if (dataText[i] == 'W' || dataText[i] == 'w')
                    temp = "W".ToString();
                else if (dataText[i] == 'X' || dataText[i] == 'x')
                    temp = "X".ToString();
                else if (dataText[i] == 'Y' || dataText[i] == 'y')
                    temp = "Y".ToString();
                else if (dataText[i] == 'Ý' || dataText[i] == 'ý')
                    temp = "YS".ToString();
                else if (dataText[i] == 'Ỳ' || dataText[i] == 'ỳ')
                    temp = "YF".ToString();
                else if (dataText[i] == 'Ỷ' || dataText[i] == 'ỷ')
                    temp = "YR".ToString();
                else if (dataText[i] == 'Ỹ' || dataText[i] == 'ỹ')
                    temp = "YX".ToString();
                else if (dataText[i] == 'Ỵ' || dataText[i] == 'ỵ')
                    temp = "YJ".ToString();
                else if (dataText[i] == 'Z' || dataText[i] == 'z')
                    temp = "Z".ToString();

                output.Text = output.Text + temp;

            }
        }
    }
}
