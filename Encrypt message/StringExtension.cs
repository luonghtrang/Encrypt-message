﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_message
{
    public static class StringExtension
    {
        public static bool IsEmpty(this string value)
        {
            return value.Length == 0;
        }
    }
}
