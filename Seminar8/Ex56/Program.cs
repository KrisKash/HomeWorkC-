using System;

namespace Ex56
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
            находить строку с наименьшей суммой элементов.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            5 2 6 7
            Программа считает сумму элементов в каждой строке и выдаёт 
            номер строки с наименьшей суммой элементов: 1 строка
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

            int SumStringArray (int [,] array, int i)
            {
                int summ = array [i,0];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summ = summ + array[i,j];               
                }
                return summ;

            }
            void MinSumm (int [,] array)
            {
                int count = 0;
                int minSumm = SumStringArray (array, 0);
                for (int i = 1; i < array.GetLength(0); i++)
                {
                    int sumLine = SumStringArray (array, i);
                    if (minSumm > sumLine)
                    {
                        minSumm = sumLine;
                        count = i;
                    }
                }
                Console.WriteLine($"Строка {count+1} является строкой с наименьшей суммой элементов.");
            }


            int [,] array = Generate2DArray(3,3);
            Console.WriteLine("Исходный массив:");
            Print2dArray(array);
            Console.WriteLine();
            MinSumm(array);
            
        }
    }
}

