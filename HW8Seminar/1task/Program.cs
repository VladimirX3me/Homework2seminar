//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив:");
int[,] array = ArrayGenerator(rows, columns, max, min);

for (int currentStringIndex = 0; currentStringIndex < rows; currentStringIndex++)
{
    SortStrOfArray(array, currentStringIndex);
}

Console.WriteLine("\nРезультат: ");
for (int i = 0; i < rows; i++)
{

    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine("<-- строка " + (i + 1));
}


void SortStrOfArray(int[,] array, int currentStringIndex)
{
    int tempMemory;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = array.GetLength(1) - 1; j > i; j--)
        {
            if (array[currentStringIndex, j] > array[currentStringIndex, j - 1])
            {
                tempMemory = array[currentStringIndex, j];
                array[currentStringIndex, j] = array[currentStringIndex, j - 1];
                array[currentStringIndex, j - 1] = tempMemory;
            }
        }
    }
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