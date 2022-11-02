// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("Введите число a: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
   Console.WriteLine("число a " + num_A + " больше чем число b " + num_B);
}
else
{
   Console.WriteLine("число b " + num_B + " больше чем число a " + num_A);
}
