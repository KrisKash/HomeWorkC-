using System;

namespace Ex64
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 64: Задайте значение N. Напишите программу, которая выведет 
            все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            N = 5 -> "5, 4, 3, 2, 1"
            N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
            */
            int GetUserInt(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine (message);
                Console.ResetColor();
                int userInt = Convert.ToInt32(Console.ReadLine());
                return userInt;
            }
            int startIndex = GetUserInt ("Введите максимальный элемент ряда: ");
            Console.WriteLine();
            PrintRange (startIndex);
            Console.WriteLine();

            void PrintRange (int index)
            {
                if (index != 0)
                {                   
                    Console.Write(index + ", ");
                    PrintRange(index-1);
                }
            }

        }
    }
}
