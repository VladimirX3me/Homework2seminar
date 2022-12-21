//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m, n;
    Console.Write("Введите начальное значение M: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение N: ");
    n = Convert.ToInt32(Console.ReadLine());

    int SumRange(int start, int end)
    {
        int sum = 0;
        if (start < end) sum = start + end + SumRange(start + 1, end - 1);
        else if (start == end) sum = end;
        return sum;
    }

    Console.WriteLine(SumRange(m, n));