using System;

namespace Ex_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 19 
            Напишите программу, которая принимает на вход пятизначное число и проверяет, 
            является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да

            N1= N/10 000
            N2= N/1000 % 10
            N3=N/100 % 10
            N4 = N/10 % 10
            N5= N % 10
            */

            int getNumberFromUser(string message)
            {
                int result = 0;
                Console.WriteLine(message);
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            int GetPalindrome (int userNumber)
            {                                
                int Numb1 = userNumber / 10000;
                int Numb2 = (userNumber / 1000) % 10;
                int Numb4 = (userNumber / 10) % 10;
                int Numb5 = userNumber % 10;
                if (Numb1 == Numb5) 
                {
                if (Numb2 == Numb4)
                    {
                        Console.WriteLine($"Число {userNumber} - является палиндром");
                    }
                }
                else
                {
                    Console.WriteLine($"Число {userNumber} - не является палиндромом");
                }
                return userNumber;

            }

            int userNumber = getNumberFromUser("Введите пятизначное число: ");
            Console.WriteLine();
            int Number = GetPalindrome(userNumber);
            Console.WriteLine();
            Console.WriteLine("ВНИМАНИЕ! Программа работает только при вводе пятизначного числа!)");


        }
    }
}
