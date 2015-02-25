using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToUnicode
{
    class Converter
    {

        public static string ToUnicode(string input)
        {
            Encoding encoding = new UnicodeEncoding();
            string unicode = string.Empty;
            byte[] bytes = encoding.GetBytes(input);
            for (int i = 0; i < bytes.Length; i += 2)
            {
                unicode += string.Format("\\u{0:x2}", bytes[i + 1]);
                unicode += string.Format("{0:x2}", bytes[i]);
            }
            return unicode;
        }

    }
}
