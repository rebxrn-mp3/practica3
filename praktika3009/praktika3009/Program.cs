using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika3009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата");
            double storona = double.Parse(Console.ReadLine());

            var per = storona * 4;
            var plo = storona * storona;

            Console.WriteLine("Периметр квадрата = " + per);
            Console.WriteLine("Площадь квадрата = " + plo);

            Console.ReadKey();

        }
    }
}
