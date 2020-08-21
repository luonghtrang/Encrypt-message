using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Encrypt_message
{
    public static class TextBoxExtension
    {
        public static bool IsEmpty(this TextBox control)
        {
            return control.Text.IsEmpty();
        }
    }
}
