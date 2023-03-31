using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class _2DMatrixRotation
    {
        public static int[,] RotateMatrixClockwise(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }


            int[,] rotated = new int[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    rotated[i, j] = transposed[i, rows - j - 1];
                }
            }

            return rotated;
        }

        public static void sss(string[] args)
        {
            int[,] matrix = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

            int[,] rotatedMatrix = RotateMatrixClockwise(matrix);

            for (int i = 0; i < rotatedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < rotatedMatrix.GetLength(1); j++)
                {
                    Console.Write(rotatedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
