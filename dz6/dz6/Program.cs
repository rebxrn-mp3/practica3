using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке: ");

            var text = Console.ReadLine();

            Console.WriteLine("Ваш текст транслитом: ");
            Console.WriteLine(TransliteTranslate(text));

            Console.ReadKey();

            var s = "клавиатура";


            var word1 = s
                .Remove(0, 6)
                .Remove(1, 3) +
                s
                .Remove(0, 4)
                .Remove(2, 2);

            var word2 =
                ReverseString(s)
                .Remove(0, 1)
                .Remove(2, 6)
            + s.Remove(0, 2)
            .Remove(1,7);


            Console.WriteLine("Исходное слово - " + s);
            Console.WriteLine("Первое полученное слово: ");
            Console.WriteLine(word1);
            Console.WriteLine("Второе полученное слово: ");
            Console.WriteLine(word2);

            Console.ReadKey();
        }

        static string ReverseString (string s)
        {
            return new string(s.Reverse().ToArray());
        }
        static string TransliteTranslate(String s)
        {
            return s
                .ToUpper()
                .Replace("А", "A")
                .Replace("Б", "B")
                .Replace("В", "V")
                .Replace("Г", "G")
                .Replace("Д", "D")
                .Replace("Е", "E")
                .Replace("Ё", "E")
                .Replace("Ж", "ZH")
                .Replace("З", "Z")
                .Replace("И", "I")
                .Replace("Й", "I")
                .Replace("К", "K")
                .Replace("Л", "L")
                .Replace("М", "M")
                .Replace("Н", "N")
                .Replace("О", "O")
                .Replace("П", "P")
                .Replace("Р", "R")
                .Replace("С", "S")
                .Replace("Т", "T")
                .Replace("У", "U")
                .Replace("Ф", "F")
                .Replace("Х", "KH")
                .Replace("Ц", "TS")
                .Replace("Ч", "CH")
                .Replace("Ш", "SH")
                .Replace("Щ", "SHCH")
                .Replace("Ъ", "IE")
                .Replace("Ы", "Y")
                .Replace("Ь", "")
                .Replace("Э", "E")
                .Replace("Ю", "IU")
                .Replace("Я", "IA");

        }

    }
}
