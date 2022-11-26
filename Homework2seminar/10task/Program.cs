// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Пример: 456 -> 5; 782 -> 8; 918 -> 1.


Console.Clear();

Console.Write("Введите число : ");
int i = Convert.ToInt32(Console.ReadLine());

string str = i.ToString();
Console.WriteLine(str[1]);

