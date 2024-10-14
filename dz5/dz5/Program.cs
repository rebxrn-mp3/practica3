using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(3, 5) * F(3, 7) * F(5, 5);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static double F(double a, double b)
        {
            return ((Math.Sin(a) + Math.Sqrt(a)) / (Math.Cos(b) + Math.Sqrt(b)));
        }
    }
}
