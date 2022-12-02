using System;

namespace Ex54
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
            по убыванию элементы каждой строки двумерного массива.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            В итоге получается вот такой массив:
            7 4 2 1
            9 5 3 2
            8 4 4 2
            */

            int [,] Generate2DArray(int lengthRow, int lengthCol)
            {
                int [,] array = new int [lengthRow,lengthCol];
                for (int i = 0; i < lengthRow; i++)
                {
                    for (int j = 0; j < lengthCol; j++)
                    {
                        array[i,j] = new Random().Next(0,10);
                    }
                }
                return array;
            }
            
            void Print2dArray(int [,] array)
            {
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j <  array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            int[,] GetNewArray (int [,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1)-1; k++)
                        {
                            if (array[i,k] < array[i,k+1])
                            {
                                int buf = array [i, k];
                                array [i, k] = array[i,k+1];
                                array [i, k+1] = buf;
                            }
                        }
                        
                    }
                }
                return array;
            }

            int [,] array = Generate2DArray(3,4);
            Console.WriteLine("Исходный массив:");
            Print2dArray(array);
            Console.WriteLine();
            int[,] arraySort = GetNewArray(array);
            Console.WriteLine("Отсортированный массив:");
            Print2dArray(arraySort);
            Console.WriteLine();

        }
    }
}
