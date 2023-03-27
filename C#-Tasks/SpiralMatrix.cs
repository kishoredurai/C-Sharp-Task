using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };


            int[] output = new int[12];
            int outputindex = 0;

            int topRow = 0;
            int bottomRow = matrix.Length - 1;
            int LeftColumn = 0;
            int RightColumn = matrix[0].Length - 1;

            while (topRow <= bottomRow && LeftColumn <= RightColumn)
            {
                // l -r
                for (int i = LeftColumn; i <= RightColumn; i++)
                {
                    output[outputindex] = matrix[topRow][i];
                    outputindex++;
                }
                topRow++;

                // t - b
                for (int i = topRow; i <= bottomRow; i++)
                {
                    output[outputindex] = matrix[i][RightColumn];
                    outputindex++;
                }
                RightColumn--;

                // r - l
               if (topRow <= bottomRow) 
                {
                    for (int i = RightColumn; i >= LeftColumn; i--)
                    {
                        output[outputindex] = matrix[bottomRow][i];
                        outputindex++;
                    }
                    bottomRow--;
                }

                // b - t
                if (LeftColumn <= RightColumn) 
                {
                    for (int i = bottomRow; i >= topRow; i--)
                    {
                        output[outputindex] = matrix[i][LeftColumn];
                        outputindex++;
                    }
                    LeftColumn++;
                }
            }

            Console.Write("[");

            foreach (int num in output)
            {

                Console.Write(num + ", ");


            }

            Console.Write("]");

        }
    }
}
