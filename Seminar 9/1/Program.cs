// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5-> "2, 4"
// M = 4; N = 8-> "4, 6, 8"

int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");
if (n < m)
{
   Console.WriteLine("Число N должно быть больше числа N");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
   if (n == m)
      return n;
   else
      Console.Write($"{NaturalNumber(n, m + 1)}, ");
   return m;
}

int InputInt(string output)
{
   Console.Write(output);
   return int.Parse(Console.ReadLine());
}