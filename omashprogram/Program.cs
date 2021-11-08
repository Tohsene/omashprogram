using System;

namespace omashprogram
{
    class Multiply4x4Matrix
    {
        
        static void Main(string[] args)
        {
            int m = 4, n = 4, p = 4, q = 4, i, j;
            int[,] a = { { 1, 4, 2, 6 }, { 2, 5, 1, 5 }, { 3, 5, 7, 5 }, { 3, 4, 2, 6 } };
            int[,] b = { { 3, 4, 2, 6 }, { 3, 5, 7,5 }, { 1, 2, 1, 3 }, { 2,4,6,7} };

            Console.WriteLine("Matrix a:");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix b:");

            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

            if (n != p)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                int[,] c = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                Console.WriteLine("The product of the two matrices is :");

                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

