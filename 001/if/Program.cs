// Найти максимальное из двух чисел.

double a, b, max = 0;
string s;
Console.Clear();

Console.Write("Введите число а=");
s = Console.ReadLine();
a = Convert.ToDouble(s);

Console.Write("Введите число b=");
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine($"max={max}");
