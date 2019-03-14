using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex60_ExtensionMethods
{
    public static class StringExtension
    {
        public static string Shift(this string str, int shift)
        {
            string temp = str.Substring(str.Length - shift);
            if (shift > 0)
            {
                str = str.Remove(str.Length - shift);
            }
            
            return str.Insert(0, temp);
        }
    }
}
