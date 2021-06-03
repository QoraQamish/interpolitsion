using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpolitsion
{
    class Program
    {
        static void Main(string[] args)
        {
            double _x, _y;
            Console.WriteLine("Dastlabki nechta nuqta kirtasiz? ");
            int n = int.Parse(Console.ReadLine());
            Lagranj lagranj = new Lagranj();
            lagranj.f = new Data[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("x[{0}]=", i);
                _x = double.Parse(Console.ReadLine());
                Console.Write("y[{0}]=", i);
                _y = double.Parse(Console.ReadLine());
                lagranj.f[i] = new Data{ x = _x, y = _y };
            }
          
            Console.Write("x* nuqtani kiriting:");
            lagranj.xi = double.Parse(Console.ReadLine());
            lagranj.print();
            Console.WriteLine("Lagranj interpolyatsiyasi y*="+lagranj.Interpolyatsiya().ToString());
            Nyuton nyuton = new Nyuton();
            nyuton.f = lagranj.f;
            Console.Write("Nyuton interpolyatsiyasi\n");
            nyuton.Interpolyatsiya(lagranj.xi);

            Console.ReadKey();
        }
    }
}
