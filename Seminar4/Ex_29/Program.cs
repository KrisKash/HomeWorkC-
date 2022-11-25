using System;

namespace Ex_29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
            и выводит их на экран.
            1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            6, 1, 33 -> [6, 1, 33]
            */

            int[] GetRandomArray (int length)
            {
                int [] array = new int [length];
                Random number = new Random ();
                for (int i = 0; i < array.Length; i++)
                {
                    array [i] = number.Next(0,999);
                }
                return array;
            }
            void PrintArray (int [] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
            int [] array = GetRandomArray(8);
            PrintArray(array);
        
        }
    }
}
