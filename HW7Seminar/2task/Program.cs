// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет: 

int arrayRows = 3;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;
int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

Console.Write("введите нужное число --> ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool numberFound = false;

for (int i = 0; i < arrayRows; i++)
{
    for (int j = 0; j < arrayColumns; j++)
    {
        if (array[i, j] == findNumber)
        {
            Console.WriteLine($"Число найено: Строка {i + 1} ; Колонка {j + 1}");
            numberFound = true;
        }
    }
}

if (numberFound != true) Console.WriteLine("Такого числа нет ");

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