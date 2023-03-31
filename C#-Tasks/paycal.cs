using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class paycal
    {
        static void d(string[] args)
        {
            List<float> list = new List<float>() { 11, 13, 40, 1.5f };
            float pay = OverTime(list);
            Console.WriteLine($"${pay}");

        }
        public static float OverTime(List<float> list)
        {
            float pay = 0;
            if (list[0] >= 9 && list[1] <= 17)
            {

                float workingHours = list[1] - list[0];
                pay = workingHours * list[2];
            }
            if (list[0] >= 9 && list[1] > 17)
            {
                pay = pay + ((list[1] - list[0]) - (list[1] - 17)) * list[2];
            }
            if (list[1] > 17)
            {
                pay = pay + (list[1] - 17) * list[2] * list[3];
            }
            return pay;
        }
    }
}
