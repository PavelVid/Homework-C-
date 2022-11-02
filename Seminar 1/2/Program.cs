// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 2 3 9 -> 22

Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
   max = num_2;
}

if (num_3 > max)
{
   max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);