using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Encrypt_message
{
    public static class WindowExtension
    {
        public static void Error(this Page window,
    string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }
}
