// Подсчитать сумму всех четных чисел от 1 до заданного значения.

Console.Clear();
int b=0,a,sum=0;
string s;
Console.Write("Введите целое число до которого необходимо подсчитать сумму чётных чисел а=");
s=Console.ReadLine();
a=Convert.ToInt32(s);

while (b<a)
{
    b=b+1;
    if (b%2==0) sum=sum+b;
}

Console.WriteLine("Сумма четгых чисел {0}", sum);