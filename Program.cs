/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine();

// Проверяем, является ли введенная строка пятизначным числом
if (input.Length != 5 || !int.TryParse(input, out int number))
{
	Console.WriteLine("Некорректный ввод. Введите пятизначное число.");
	return;
}

// Проверяем, является ли число палиндромом
bool isPalindrome = CheckPalindrome(number);
if (isPalindrome)
{
	Console.WriteLine("Да, введенное число является палиндромом.");
}
else
{
	Console.WriteLine("Нет, введенное число не является палиндромом.");
}

// Метод для проверки палиндрома
static bool CheckPalindrome(int number)
{
	string numberStr = number.ToString();
	int length = numberStr.Length;
	for (int i = 0; i < length / 2; i++)
	{
		if (numberStr[i] != numberStr[length - i - 1])
		{
			return false;
		}
	}
	return true;
}
*/


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


		Console.WriteLine("Введите координаты точки A (x, y, z):");
		double[] pointA = ReadCoordinates();

		Console.WriteLine("Введите координаты точки B (x, y, z):");
		double[] pointB = ReadCoordinates();

		double distance = CalculateDistance(pointA, pointB);

		Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");


	static double[] ReadCoordinates()
	{
		Console.Write("x = ");
		double x = double.Parse(Console.ReadLine());

		Console.Write("y = ");
		double y = double.Parse(Console.ReadLine());

		Console.Write("z = ");
		double z = double.Parse(Console.ReadLine());

		return new double[] { x, y, z };
	}

	static double CalculateDistance(double[] pointA, double[] pointB)
	{
		double dx = pointB[0] - pointA[0];
		double dy = pointB[1] - pointA[1];
		double dz = pointB[2] - pointA[2];

		double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
		return distance;
	}
*/
