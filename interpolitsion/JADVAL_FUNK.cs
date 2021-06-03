using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace interpolitsion
{
    public class Data
    {
        public double x { get; set; }
        public double y { get; set; }
    }
    public class JADVAL_FUNK
    {
        //Dastlabki berilgan static jadval:
        public Data[] f { get; set; }
        // Nuqtadagi qiymat
        public double xi { get; set; }
        //Masivni erkanga jadval qilib chiqarish:
        public void print()
        {
            Console.Write("------------------\ni: ");
            for (int i = 0; i < f.GetLength(0); i++)
            {
                Console.Write(" "+f[i].x);
            }
            Console.Write("\nxi:");
            for (int i = 0; i < f.GetLength(0); i++)
            {
                Console.Write(" " + f[i].y);
            }
            Console.WriteLine("\n-------------------");
        }
        public virtual double Interpolyatsiya(double result)
        {
            return result;
        }
    }
}