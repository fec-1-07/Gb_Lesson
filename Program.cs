
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16




		  Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <= b; i++)
{
	result *= a;
}

Console.WriteLine($"Результат: {result}");

*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр: {sum}");
   
*/
