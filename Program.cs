/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(GenerateNumbers(n));


static string GenerateNumbers(int n)
{
	if (n == 1)
		return "1";

	return n + ", " + GenerateNumbers(n - 1);
}


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите значение M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} = {CalculateSum(m, n)}");


static int CalculateSum(int m, int n)
{
	int sum = 0;
	for (int i = m; i <= n; i++)
	{
		sum += i;
	}
	return sum;
}
