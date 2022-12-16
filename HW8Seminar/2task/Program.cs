//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int arraymin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int arraymax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив:");
int[,] array = new int[rows, columns];

int currentMinStringValue = Int32.MaxValue;
int currentIndexMinString = -1;

for (int i = 0; i < rows; i++)
{
    int sumStringElement = 0;
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(arraymin, arraymax);
        Console.Write(array[i, j] + "\t|");
        sumStringElement += array[i, j];
    }
    Console.WriteLine("<-- строка " + (i + 1) + " сумма = " + sumStringElement);
    if (sumStringElement < currentMinStringValue)
    {
        currentMinStringValue = sumStringElement;
        currentIndexMinString = i;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: \nстрока " + (currentIndexMinString + 1) + " сумма = " + currentMinStringValue);