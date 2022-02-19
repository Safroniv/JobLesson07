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
            int a = 10;
            int b = a;
            if (b == a)
            {
                Console.WriteLine("Hallo World");
            }

            
        }
    }
}
