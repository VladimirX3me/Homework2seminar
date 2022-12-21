//Задача 68: Задайте значения M и N. Напишите программу, которая найдёт 
//наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
//M = 28; N = 7 -> 7


int m, n;
Console.Write("Введите начальное значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение N: ");
n = Convert.ToInt32(Console.ReadLine());

int FindNod(int m, int n)
{
    if (n == 0)
        return m;
    else
        return FindNod(n, m % n);
}

Console.WriteLine(FindNod(m, n));