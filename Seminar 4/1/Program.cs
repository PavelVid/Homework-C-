// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Write("Введите число A: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int count = 1;
int result = num_a;

while (count < num_b)
{
   result = result * num_a;
   count++;
}

System.Console.WriteLine($"{num_a} ^ {num_b} = {result}");
System.Console.WriteLine();