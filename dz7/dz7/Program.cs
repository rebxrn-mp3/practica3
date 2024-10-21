using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = GetNumber("m");
            var n = GetNumber("n");

            Console.WriteLine(" Результат логического выражения: " + ChetChislo(m, n));

            Console.ReadKey();

            var x = GetNumber("x");
            var y = GetNumber("y");

            Console.WriteLine(" Результат логического выражения: " + CheckArea(x, y));

            Console.ReadKey();


        }
        static int GetNumber (string numbername)
        {
            Console.WriteLine($"Введите число {numbername}: ");
            return int.Parse(Console.ReadLine());
        }
        static bool ChetChislo(int m, int n)
        {
            return (m % 2 == 0 && n % 2 != 0) || (n % 2 == 0 && m % 2 != 0);
        }

        static bool CheckArea(int x, int y)
        {
            return (x>=2 && y>=0) || (x>=1 && y<=-1);
        }
    }
}
