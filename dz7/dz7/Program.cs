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

            if (CheckArea(x,y))
                Console.WriteLine("Точка принадлежит указанной области ");
            else
                Console.WriteLine("Точка не принадлежит указанной области ");

            Console.ReadKey();

            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();

            int whitePawnRow, whitePawnColumn;

            DecodePosition(whitePawnPosition, out whitePawnRow, out whitePawnColumn);
            Console.WriteLine($"({whitePawnRow}; {whitePawnColumn})");

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
        static void DecodePosition(string position, out int x, out int y)
        {
        x = int.Parse(position[1].ToString());
        y = (int)position[0] - 0x60;
        }
}
}
