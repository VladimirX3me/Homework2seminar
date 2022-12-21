//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8

int m, n;
Console.Write("Введите начальное значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение N: ");
n = Convert.ToInt32(Console.ReadLine());

void PrintRange(int start, int end)
{
    if (end > start)
    {
        PrintRange(start, end - 2);
        Console.Write(", ");
    }
    Console.Write(end);
}

PrintRange(m, n);
Console.WriteLine();