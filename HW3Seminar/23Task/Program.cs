﻿// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
while (a <= b)
{
    Console.WriteLine((a * a * a));
    a++;
}