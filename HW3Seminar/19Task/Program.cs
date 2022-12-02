// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
{
    Console.Write("Введите число: ");
    uint a = uint.Parse(Console.ReadLine());
    uint b = a;
    var col = new List<uint>();
    while (b > 0)
    {
        col.Add(b % 10);
        b = b / 10;
    }
    b = 0;
    col.Reverse();
    for (int mcol = 0; mcol < col.Count; mcol++)
        b = b + col[mcol] * (uint)Math.Pow(10, mcol);
    if (a == b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}