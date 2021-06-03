using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace interpolitsion
{
    public class Nyuton:JADVAL_FUNK
    {
        
        public override double Interpolyatsiya(double result)
        {
            xi = result;
            int n = f.GetLength(0);
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = f[i].x;
            }

            double[,] y = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                y[i, 0] = f[i].y;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                    y[j, i] = y[j + 1, i - 1] - y[j, i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(x[i] + "\t");
                for (int j = 0; j < n - i; j++)
                    Console.Write(y[i, j] + "\t");
                Console.WriteLine();
            }
           
            double sum = y[0, 0];
            double u = (xi - x[0]) / (x[1] - x[0]);
            for (int i = 1; i < n; i++)
            {
                sum = sum + (u_cal(u, i) * y[0, i]) /
                                        fact(i);
            }

            Console.WriteLine("\n Value at " + xi + " is " + Math.Round(sum, 6));

            return base.Interpolyatsiya(sum);    
        }
        // calculating u mentioned in the formula
        static double u_cal(double u, int n)
        {
            double temp = u;
            for (int i = 1; i < n; i++)
                temp = temp * (u - i);
            return temp;
        }

        // calculating factorial of given number n
        static int fact(int n)
        {
            int f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
        
    }
}