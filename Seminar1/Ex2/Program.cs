using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberA = new int();
            Console.WriteLine("Введите число А:");
            NumberA = Convert.ToInt32(Console.ReadLine());
            int NumberB = new int();
            Console.WriteLine("Введите число В:");
            NumberB = Convert.ToInt32(Console.ReadLine());
            int NumberC = new int();
            Console.WriteLine("Введите число C:");
            NumberC = Convert.ToInt32(Console.ReadLine());
            int max = NumberA;
            if(NumberA > max) 
                max = NumberA;
            if(NumberB > max)
                max = NumberB;
            if(NumberC > max)
                max = NumberC;
            Console.WriteLine("Максмальное число: ");
            Console.WriteLine(max);
        }
    }
}
