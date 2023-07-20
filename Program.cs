/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

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


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// Шаг 1: Спрашиваем у пользователя, чтобы он ввел значение m
Console.WriteLine("Введите значение m:");

// Шаг 2: Считываем введенное пользователем значение m
int m = int.Parse(Console.ReadLine());

// Шаг 3: Спрашиваем у пользователя, чтобы он ввел значение n
Console.WriteLine("Введите значение n:");

// Шаг 4: Считываем введенное пользователем значение n
int n = int.Parse(Console.ReadLine());

// Шаг 5: Вызываем функцию Ackermann, передавая в нее значения m и n
int result = Ackermann(m, n);

// Выводим результат на экран
Console.WriteLine($"A({m}, {n}) = {result}");

// Шаг 6: Определяем функцию Ackermann
static int Ackermann(int m, int n)
{
	// Шаг 7: Проверяем, равно ли m нулю
	if (m == 0)
	{
		// Шаг 8: Если m равно нулю, возвращаем n + 1
		return n + 1;
	}
	else if (m > 0 && n == 0)
	{
		// Шаг 9: Если m больше нуля и n равно нулю, вызываем функцию Ackermann(m - 1, 1)
		return Ackermann(m - 1, 1);
	}
	else if (m > 0 && n > 0)
	{
		// Шаг 10: Если и m, и n больше нуля, вызываем функцию Ackermann(m - 1, Ackermann(m, n - 1))
		return Ackermann(m - 1, Ackermann(m, n - 1));
	}
	else
	{
		// Шаг 11: Если m или n меньше нуля, вызываем исключение
		throw new ArgumentException("Функция Аккермана определена только для неотрицательных чисел.");
	}
}


