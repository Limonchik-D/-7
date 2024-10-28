using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. вывести в столбик 10 раз слово "Привет";
            /*
            Console.WriteLine("Сколько раз ввывести слово - Привет ?");
            int number = int.Parse(Console.ReadLine());
            int t = 0;
            while (number > t)
            {
                Console.WriteLine("Привет");
                t ++;
            }
            */

            //2. вывести в столбик первые 10 натуральных чисел;
            /*
             * Console.WriteLine("Сколько вывести натуральных чисел ?");
            int number = int.Parse(Console.ReadLine());
            int r = 1;

            do
            {
                Console.WriteLine(r); // Здесь выводим значение r
                r++;
            }
            while (r <= number);
            */

            //3. вывести в столбик первые 5 натуральных чисел в обратном порядке;
            /*Console.WriteLine("Сколько вывести натуральных чисел ?");
            
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/

            //4. вывести на экран целые числа из интервала от 1 до n;
            /*
             * Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());
            

            for (int c = 1; c <= number; c++)
            {
                Console.WriteLine(c); 
            }
            */

            //5. запросить у пользователя 5 слов, после чего вывести вначале дважды каждое нечетное слово и затем трижды каждое четное слово, между выводимыми словами вставить разделитель в виде трех символьных пробелов (“   ”).
            /*
            Console.WriteLine("Введите 5 слов: ");
            string[] words = new string[5];
            
            for (int i = 0; i < 5; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.Write("Результат: ");
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0) // нечетные индексы (1, 3, 5)
                {
                    Console.WriteLine(words[i] + "   " + words[i]);
                }
                else // четные индексы (2, 4)
                {
                    Console.WriteLine(words[i] + "   " + words[i] + "   " + words[i]);
                }

            }*/

        }

    }
}
