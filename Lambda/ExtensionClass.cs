using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Basics
{
    static class ExtensionClass
    {
        public static string Hide(this string value)
        {
            Regex regex = new Regex(".");
            return regex.Replace(value, "#");
        }
    }
}
