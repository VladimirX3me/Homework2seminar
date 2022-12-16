//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int arrayrows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int arraycolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int arraymin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int arraymax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив А:");

int[,] arrayA = ArrayGenerator(arrayrows, arraycolumns, arraymax, arraymin);

Console.WriteLine("\nИсходный массив B:");
int[,] arrayB = ArrayGenerator(arrayrows, arraycolumns, arraymax, arraymin);

int[,] resultArray = new int[arrayrows, arraycolumns];

Console.WriteLine("\nРезультат:");
for (int i = 0; i < arrayrows; i++)
{
    for (int j = 0; j < arraycolumns; j++)
    {
        resultArray[i, j] = arrayA[i, j] * arrayB[i, j];
        Console.Write(resultArray[i, j] + "\t|");
    }
    Console.WriteLine("<-- строка " + (i + 1));
}

int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int maxValue, int minValue) // рандом генератор
{
    int[,] array = new int[lenghtRows, lenghtColum];
    for (int i = 0; i < lenghtRows; i++)
    {
        for (int j = 0; j < lenghtColum; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine("<-- строка " + (i + 1));
    }
    return array;
}