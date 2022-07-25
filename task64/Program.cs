// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumDigits(int m, int n, int summ = 0)
{
    if (m > n)
    {
        System.Console.WriteLine(summ);
        return;
    }
    summ = summ + m;
    SumDigits(m + 1, n, summ);
}

System.Console.WriteLine("введите число M");
int m = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("введите число N");
int n = Int32.Parse(Console.ReadLine());
SumDigits(m, n);