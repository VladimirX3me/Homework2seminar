// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int arrayLenght, arrayMaxValue, arrayMinValue, count;
int[] arrayInt = { };
arrayLenght = 5;
arrayMaxValue = 1000;
arrayMinValue = 100;
count = 0;

arrayInt = ArrayRandom(arrayLenght, arrayMaxValue, arrayMinValue);

for (int i = 0; i < arrayLenght; i++)
{
    if (arrayInt[i] % 2 == 0) count++;
}
Console.WriteLine($"Чётные числа = {count}");

int[] ArrayRandom(int lenght, int maxValue, int minValue)
{
    int[] arrayInt = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        arrayInt[i] = new Random().Next(minValue, maxValue);
        Console.Write(arrayInt[i] + "; ");
    }
    Console.WriteLine();
    return arrayInt;
}