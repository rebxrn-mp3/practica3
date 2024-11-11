using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("F(x)="+Func(x));

            Console.ReadKey();
        }

        static double Func (double x)
        {
            if (Math.Sin(x) < -0.5) return Math.Sin(x);
            else if (-0.5 <= Math.Sin(x) && Math.Sin(x) <= 0.5) return 0;
            else return 1 ;
        }
    }
}
