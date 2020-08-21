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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Mahoachuchu_Click(object sender, RoutedEventArgs e)
        {
            MH_CC pageMHCC = new MH_CC();
            this.NavigationService.Navigate(pageMHCC);
        }

        private void Mahoachuso_Click(object sender, RoutedEventArgs e)
        {
            MH_CS pageMHCS = new MH_CS();
            this.NavigationService.Navigate(pageMHCS);
        }

        private void Giaimachuchu_Click(object sender, RoutedEventArgs e)
        {
            GM_CC pageGMCC = new GM_CC();
            this.NavigationService.Navigate(pageGMCC);
        }

        private void Giaimasochu_Click(object sender, RoutedEventArgs e)
        {
            GM_CS pageGMCS = new GM_CS();
            this.NavigationService.Navigate(pageGMCS);
        }

        private void Morse_Click(object sender, RoutedEventArgs e)
        {
            MH_Morse pageMorse = new MH_Morse();
            this.NavigationService.Navigate(pageMorse);
        }

        private void Telex_Click(object sender, RoutedEventArgs e)
        {
            TelexTranslate pageTelex = new TelexTranslate();
            this.NavigationService.Navigate(pageTelex);

        }

    }
}
