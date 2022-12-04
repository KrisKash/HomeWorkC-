using System;

namespace Ex60
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
            Напишите программу, которая будет построчно выводить массив, 
            добавляя индексы каждого элемента.
            Массив размером 2 x 2 x 2
            66(0,0,0) 25(0,1,0)
            34(1,0,0) 41(1,1,0)
            27(0,0,1) 90(0,1,1)
            26(1,0,1) 55(1,1,1) 

             Решение Димы
            int a = 2, b = 2, c = 2;
            int FirstNumber = 10, SecondNumber = 100;
            int[] numbers = new int[SecondNumber - FirstNumber];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = FirstNumber + i;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int index = new Random().Next(i + 1, numbers.Length);
                int temp = numbers[i];
                numbers[i] = numbers[index];
                numbers[index] = temp;
            }
            int[,,] TripleMatrix = new int[a, b, c];
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int z = 0; z < c; z++)
                    {
                        TripleMatrix[i, j, z] = numbers[count];
                        Console.Write($" {TripleMatrix[i, j, z]}({i},{j},{z})");
                        count++;
                    }
                    Console.WriteLine();
                }
            } */

            
            
            int [,,] Get3DArray ( int z, int x, int y, int min, int max)
            {
                int [,,] array = new int [z, x, y];
                Random random = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i,j,k] = random.Next(min, max + 1);
                        }
                    }
                }
                return array;
            }
            void Print3DArray(int [,,] array)
            {
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j <  array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            Console.Write($" {array[i,j,k]} ({i}, {j}, {k})" + "\t");
                        }  
                        Console.WriteLine();                
                    }
                    Console.WriteLine();   
                }
            }

            int x = 2;
            int y = 2;
            int z = 2;
            int min = 10;
            int max = 99;
            int [,,] array = Get3DArray (z, x, y, min, max);
            Print3DArray(array);
            
           
        }
    }
}
