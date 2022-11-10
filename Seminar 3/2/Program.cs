// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

using System;
namespace New_Project
{
   class Program
   {
      public static void Main()
      {
         double[] x = new double[6];
         double d, distance = 0.0;
         Console.WriteLine("Введите координаты 2-х точек через пробел.");
         Console.WriteLine("x1 y1 z1 x2 y2 z3:");
         var line = Console.ReadLine().Split();
         for (int i = 0; i < 3; i++)
         {
            d = Convert.ToDouble(line[i + 3]) - Convert.ToDouble(line[i]);
            distance += d * d;
         }
         Console.WriteLine("Расстояние = " + Math.Sqrt(distance));
      }
   }
}