/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

string s = String.Empty;
Console.WriteLine(s);
Console.Write("Введите число: ");

var number = Convert.ToInt32(Console.ReadLine());
string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int i = number - 1;

if (i < 5)
{
    Console.WriteLine($"День недели: {daysOfWeek[i]} - будний день");
}

else
{
    Console.WriteLine($"День недели: {daysOfWeek[i]} - выходной день");
}

Console.WriteLine(s);
