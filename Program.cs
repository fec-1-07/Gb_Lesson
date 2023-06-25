// See https://aka.ms/new-console-template for more information

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine());

// Получаем вторую цифру числа
int secondDigit = (number / 10) % 10; /*В этой строке получаем вторую цифру числа number. Делим число на 10, чтобы сдвинуть цифры вправо на одну позицию, а затем берем остаток от деления на 10, чтобы получить вторую цифру.*/

Console.WriteLine("Вторая цифра числа: " + secondDigit);


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int thirdNumber = GetThirdNumber(number);

if (thirdNumber != -1)
{
	Console.WriteLine("Третья цифра числа: " + thirdNumber);
}
else
{
	Console.WriteLine("Третьей цифры нет");
}


static int GetThirdNumber(int number)
{
	int numberCount = (int)Math.Floor(Math.Log10(number) + 1);

	if (numberCount < 3)
	{
		return -1;
	}
	else
	{
		int thirdNumber = (number / 100) % 10;
		return thirdNumber;
	}
}


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Введите номер дня недели (от 1 до 7):");
int dayWeek = int.Parse(Console.ReadLine());
bool isWeekend = IsWeekend(dayWeek);
static bool IsWeekend(int dayWeek)
{
	return dayWeek == 6 || dayWeek == 7;
}

if (isWeekend)
{
	Console.WriteLine("Да, это выходной день");
}
else
{
	Console.WriteLine("Нет, это не выходной день");
}
