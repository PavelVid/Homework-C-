// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
System.Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
   int digit = number % 10;
   sum = sum + digit;
   number = number / 10;
}

System.Console.WriteLine(sum);