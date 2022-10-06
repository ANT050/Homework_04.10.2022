/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/

/*
ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ
*/

string s = String.Empty;
Console.WriteLine(s);

Console.Write("Введите трехзначное число: ");

var number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
var m = str.Length;
var n = 2;

if (m <= n)
{
    Console.WriteLine("Число не содержит третьей цифры");
}
else
{
    Console.WriteLine($"Вторая цифра числа {number} -> {str[2]}");
}

Console.WriteLine(s);


/*
ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ
*/

/*

string s = String.Empty;
Console.WriteLine(s);
Console.Write("Введите число: ");

var numbers = Convert.ToInt32(Console.ReadLine());

if (numbers < 100)
{
    Console.WriteLine("Третья цифра отсутствует, число не соответствует условию задачи!");
}

if (100 <= numbers && numbers < 1000)
{
    Console.WriteLine($"Третья цифра равна: {numbers % 10}");
}

if (1000<= numbers && numbers < 10000)
{
    Console.WriteLine("Число не соответствует условию задачи");
}

if (10000 <= numbers && numbers < 100000)
{
    Console.WriteLine($"Третья цифра равна: {(numbers / 100) % 10}");
}

if (numbers >=100000)
{
    Console.WriteLine("Число не соответствует условию задачи!");
}

Console.WriteLine(s);

*/

/* 
ТРЕТИЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ
*/

/*

string s = String.Empty;
Console.WriteLine(s);
Console.Write("Введите число: ");

var numbers = Convert.ToInt32(Console.ReadLine());
var mas = numbers.ToString();
var m = mas.Length;

int[] b = new int[mas.Length];

for (int i = 0; i < mas.Length; i++)
{
    b[i] = int.Parse(mas[i].ToString());
}

Console.Write("Введите номер числа: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Номер числа не может быть равен или меньше '0'");
}

else
{
    if (n <= m)
    {
        Console.WriteLine($"Число равно: {b[n - 1]}");
    }

    else
    {
        Console.WriteLine("Значение отсутсвсует!");
    }
}

Console.WriteLine(s);

*/
