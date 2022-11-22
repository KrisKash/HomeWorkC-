using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 15: Напишите программу, которая принимает на вход цифру, 
            // обозначающую день недели, и проверяет, является ли этот день выходным.
            // 6 -> да, 7 -> да, 1 -> нет

            /*
            int number = new Random().Next(1,8);
            if (number < 6) 
            {
                Console.WriteLine($" {number} - нет ");
            }
            else
            {
                Console.WriteLine($" {number} - да ");
            }
            */

            int GetRandomNumber(int start, int end)
            {
                int result = 0;
                result = new Random().Next(start, end + 1);
                return result;
            }
            
            int RandomNumber = GetRandomNumber(1,7);
            if (RandomNumber < 6)
            {
                Console.WriteLine($" {RandomNumber} - будний день");
            }
            else
            {
                Console.WriteLine($" {RandomNumber} - выходной день");
            }
            
            

            
        }
    }
}
