﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number /= 10;
}
Console.WriteLine("Сумма введёных чисел {0}", sum);