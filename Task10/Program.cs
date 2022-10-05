/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

string s = string.Empty;
Console.WriteLine(s);
Console.Write("Введите число: ");

var numbers = Convert.ToInt32(Console.ReadLine());

if (numbers < 100)
{
    Console.WriteLine($"Число {numbers} не соответствует условию задачи");
}

if (numbers >= 100 && numbers < 1000)
{
    Console.WriteLine($"Вторая цифра числа: {(numbers / 10) % 10}");
}

if (numbers >= 1000)
{
    Console.WriteLine($"Число {numbers} не соответствует условию задачи");
}

Console.WriteLine(s);

/*
ДРУГОЙ СПОСОБ РЕШЕНИЯ
*/

/*string s = String.Empty;
Console.WriteLine(s);
Console.Write("Введите число: ");

var numbers = Convert.ToInt32(Console.ReadLine());
var mas = numbers.ToString();

int[] b = new int[mas.Length];

for (int i = 0; i < mas.Length; i++)
{
    b[i] = int.Parse(mas[i].ToString());
}

Console.Write("Введите номер числа: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число равно: {b[n-1]}");
Console.WriteLine(s);

*/