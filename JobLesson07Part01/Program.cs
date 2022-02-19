using System;

namespace JobLesson07Part01
{
    //Урок 7 Задание 1
    //Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
    //декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать приложение.
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input b");
            int b = Int32.Parse(Console.ReadLine());
            int a = 10;
            
            if (b == a)
            {
                Console.WriteLine("Hallo World");
            }
            else
            {
                Console.WriteLine("b not a");
            }
            Console.ReadLine();
        }
    }
}
