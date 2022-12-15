﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// например: 
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().NextDouble();
        array[i, j] = array[i, j] * (max - min) + min;
        array[i, j] = Math.Round(array[i, j], 2);
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine("<-строка " + (i + 1));
}