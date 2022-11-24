using System;

namespace Ex_25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 25: Напишите цикл, который принимает на вход два числа (A и b) 
            и возводит число A в натуральную степень B.
            3, 5 -> 243 (3⁵)
            2, 4 -> 16
            */

            int getNumberFromUser(string message)
            {
                int result = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
                Console.ResetColor();
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int Exponention (int numbA, int numbB)
            {
                int count = 1;
                for (int i = 0; i < numbB; i++)
                {
                    count = count * numbA;
                }
                return count;
            }

            int numbA = getNumberFromUser ("Введите число А:");
            int numbB = getNumberFromUser ("Введите число B:");
            int count = Exponention (numbA, numbB);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numbA} возведенное в степень {numbB} = {count} ");
            Console.ResetColor();
        }
    }
}
