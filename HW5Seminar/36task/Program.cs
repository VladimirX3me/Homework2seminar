// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int arrayLenght, arrayMaxValue, arrayMinValue, sum;
arrayLenght = 5;
arrayMaxValue = 10;
arrayMinValue = -10;
sum = 0;
int[] arrayInt = { };

arrayInt = ArrayRandom(arrayLenght, arrayMaxValue, arrayMinValue);

for (int i = 1; i < arrayLenght; i += 2)
{
    sum += arrayInt[i];
}

Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

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