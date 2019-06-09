using System;

namespace Lesson4_2d_t943
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             943. Определить:
                а) сумму элементов главной диагонали массива;
                б) сумму элементов побочной диагонали массива.
                в) среднее арифметическое элементов главной диагонали массива;
                г) среднее арифметическое элементов побочной диагонали массива.
                д) минимальный элемент главной диагонали массива;
                е) максимальный элемент побочной диагонали массива.
                ж) максимальный элемент главной диагонали массива;
                з) минимальный элемент побочной диагонали массива.
             */

            Console.Write("Введите размер квадратной матрицы: ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"[{i};{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            int principalDiagSum = 0, principalDiagMin = matrix[0, 0], principalDiagMax = matrix[0, 0];
            int secondaryDiagSum = 0, secondaryDiagMin = matrix[0, matrixSize - 1], secondaryDiagMax = matrix[0, matrixSize - 1];

            Console.WriteLine("Матрица:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(Convert.ToString(matrix[i, j]).PadRight(6, ' '));
                    if (i == j)
                    {
                        // principal dialonal
                        getMinMax(matrix[i, j], ref principalDiagSum, ref principalDiagMin, ref principalDiagMax);
                    }

                    if (i + j == matrixSize - 1)
                    {
                        // secondary diagonal
                        getMinMax(matrix[i, j], ref secondaryDiagSum, ref secondaryDiagMin, ref secondaryDiagMax);
                    }
                }
                Console.WriteLine();
            }

            double principalDiagAvg = Math.Round((double)principalDiagSum / matrixSize, 2);
            double secondaryDiagAvg = Math.Round((double)secondaryDiagSum / matrixSize, 2);

            Console.WriteLine("\n");
            Console.WriteLine("а) сумму элементов главной диагонали массива: " + principalDiagSum);
            Console.WriteLine("б) сумму элементов побочной диагонали массива: " + secondaryDiagSum);
            Console.WriteLine("в) среднее арифметическое элементов главной диагонали массива: " + principalDiagAvg);
            Console.WriteLine("г) среднее арифметическое элементов побочной диагонали массива: " + secondaryDiagAvg);
            Console.WriteLine("д) минимальный элемент главной диагонали массива: " + principalDiagMin);
            Console.WriteLine("е) максимальный элемент побочной диагонали массива: " + secondaryDiagMax);
            Console.WriteLine("ж) максимальный элемент главной диагонали массива: " + principalDiagMax);
            Console.WriteLine("з) минимальный элемент побочной диагонали массива: " + secondaryDiagMin);
            Console.WriteLine();
        }

        private static void getMinMax(int v, ref int sum, ref int min, ref int max)
        {
            sum += v;

            if (v < min)
                min = v;

            if (v > max)
                max = v;
        }
    }
}
