using System;

namespace Ex_21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 21
            Напишите программу, которая принимает на вход координаты двух точек 
            и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
            */

            int getNumberFromUser(string message)
            {
                int result = 0;
                Console.WriteLine(message);
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            double GetDistance (double xa, double ya, double za, double xb, double yb, double zb)
            {
               double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2) );
               return distance;
            }
            int xa = getNumberFromUser("Введите X1:");
            int ya = getNumberFromUser("Введите Y1:");
            int za = getNumberFromUser("Введите Z1:");
            int xb = getNumberFromUser("Введите X2:");
            int yb = getNumberFromUser("Введите Y2:");
            int zb = getNumberFromUser("Введите Z2:");

            double distance = GetDistance(xa, ya, za, xb, yb, zb);
            Console.WriteLine($"Расстояние между точками равно {distance} ");
        }
    }
}
