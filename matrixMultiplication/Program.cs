using System;

namespace matrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] D = { 1, 2 };
            int[] E = { 3, 4 };
            int[] F = { 1, 2 };
            int[] G = { 3, 4 };

            int[][] Test1 = { D, E };
            int[][] Test2 = { F, G };

            double[][] res = matrixMultiplication(Test1, Test2);
            double[] res1 = res[0];
            double[] res2 = res[1];

            double res3 = res1[0];
            double res4 = res1[1];
            double res5 = res2[0];
            double res6 = res2[1];

            Console.WriteLine($"[[{res3}, {res4}],[{res5}, {res6}]]");
        }

        public static double[][] matrixMultiplication(int[][] A, int[][] B)
        {
            int n = A.Length;
            int i = 0;
            double[] D = { 0, 0 };
            double[] E = { 0, 0 };
            double[][] C = { D, E };

            while (i < n)
            {
                int j = 0;
                while (j < n)
                {
                    C[i][j] = 0.0;

                    int k = 0;
                    while (k < n)
                    {
                        C[i][j] = C[i][j] + A[i][k] * B[k][j];
                        k++;
                    }
                    j++;
                }
                i++;
            }
            return C;
        }
    }
}
