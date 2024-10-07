using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число х: ");
            var x = double.Parse(Console.ReadLine());

            var y = myFunc(x);
            Console.WriteLine($"f(x)={y}");
            Console.ReadKey();
        }

        static double myFunc(double x)
        {
            return (2*Math.Cos(1 / (Math.Pow(x, 2) +1)) / (Math.Pow(x, 3) + 1));
        }
    }
}
