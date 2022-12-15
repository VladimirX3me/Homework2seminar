// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int arrayRows = 3;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;

int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

Console.WriteLine("Среднее арифметическое столбцов:");

double arithmeticalMean = 0;

for (int j = 0; j < arrayColumns; j++)
{
    for (int i = 0; i < arrayRows; i++)
    {
        arithmeticalMean += array[i, j];
    }
    arithmeticalMean = Math.Round(arithmeticalMean / arrayRows, 3);
    Console.Write(arithmeticalMean + "\t|");
    arithmeticalMean = 0;
}
Console.WriteLine();

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
        Console.WriteLine("<-строка " + (i + 1));
    }
    return array;
}