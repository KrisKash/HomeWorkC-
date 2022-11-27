using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = new int();
            Console.WriteLine("Введите число:");
            Number = Convert.ToInt32(Console.ReadLine());
            if(Number % 2 == 0)
                Console.WriteLine("Четное");
            else
                Console.WriteLine("Нечетное");
        }
    }
}
