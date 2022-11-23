using System;

namespace Ex_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 23
            Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125
            */

            int getNumberFromUser(string message)
            {
            int result = 0;
            Console.WriteLine(message);
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            }

            int Solution(int userNumber)
            {
                Console.WriteLine($"Таблица кубов чисел от 1 до {userNumber}");
                for (int i = 1; i <= userNumber; i++)
                {
                    double Numb = Math.Pow(i, 3);
                    Console.WriteLine($"{Numb}");
                }
                return userNumber;
            }
            int userNumber = getNumberFromUser("Введите число:");
            Console.WriteLine();
            double Numb = Solution(userNumber);
            
        }
    }
}
