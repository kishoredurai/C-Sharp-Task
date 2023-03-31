using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class LicensePlateFromat
    {
        public static string LicensePlaceFormatter(string s, int n)
        {

            string cleaned = new string(s.ToUpper().Replace("-", "").ToCharArray());  // remove all - and convert to uppercanse
            Console.WriteLine(cleaned);
            int i = cleaned.Length - n;
            while (i > 0)   // loop to split and insert a - in between
            {
                cleaned = cleaned.Insert(i, "-");
                i -= n;
            }

            return cleaned;
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine(LicensePlaceFormatter("5F3Z-2e-9-w", 4)); // "5F3Z-2E9W"
            Console.WriteLine(LicensePlaceFormatter("2-5g-3-J", 2)); // "2-5G-3J"
            Console.WriteLine(LicensePlaceFormatter("2-4A0r7-4k", 3)); // "24-A0R-74K"
            Console.WriteLine(LicensePlaceFormatter("nlj-206-fv", 3)); // "NL-J20-6FV"

        }
    }
}
