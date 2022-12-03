// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число   : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень : ");
int n = Convert.ToInt32(Console.ReadLine());

int num_n = 1;

for (int i = 0; i < n; i++)
    {
        num_n *= num;
    }
Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
