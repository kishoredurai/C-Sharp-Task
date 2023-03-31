using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class LicenceProcessTimeCalculator
    {
        public static int LicenceCalculateTime(string me, int agents, string others)
        {
            string[] otherNames = (me + " " + others).Split(' ');

            Array.Sort(otherNames);

            int myIndex = Array.IndexOf(otherNames, me);

            int totalTime = 20 * (myIndex / agents + 1);

            return totalTime;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(LicenceCalculateTime("Eric", 2, "Adam Caroline Rebecca Frank")); // 40
            Console.WriteLine(LicenceCalculateTime("Zebediah", 1, "Bob Jim Becky Pat")); // 100
            Console.WriteLine(LicenceCalculateTime("Aaron", 3, "Jane Max Olivia Sam")); // 20
        }
    }
}
