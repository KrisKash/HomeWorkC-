using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, которая на вход принимает два числа и выдаёт, 
            какое число большее, а какое меньшее.
            a = 5; b = 7 -> max = 7
            a = 2 b = 10 -> max = 10
            a = -9 b = -3 -> max = -3*/
            
            int NumberA = new int();
            Console.WriteLine("Введите число А:");
            NumberA = Convert.ToInt32(Console.ReadLine());
            int NumberB = new int();
            Console.WriteLine("Введите число В:");
            NumberB = Convert.ToInt32(Console.ReadLine());
            if (NumberA > NumberB)
            {
                Console.Write("Большее число:");
                Console.WriteLine(NumberA);
                Console.Write("Меньшее число:");
                Console.WriteLine(NumberB);

            }   
            else
            {
                Console.Write("Большее число:");
                Console.WriteLine(NumberB);
                Console.Write("Меньшее число:");
                Console.WriteLine(NumberA);
            }
        }
    }
}
