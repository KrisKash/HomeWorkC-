using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = new int();
            Console.WriteLine("Введите число:");
            N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            Console.WriteLine("Все четные числа:");
            while (i < N - 1)
            {
                i +=2;
                Console.WriteLine(i);
            }
        }
    }
}
