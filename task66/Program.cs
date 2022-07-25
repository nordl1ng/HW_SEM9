// Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

System.Console.WriteLine("введите число M");
int m = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("введите число N");
int n = Int32.Parse(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
        System.Console.WriteLine(n + 1);
    }
    else
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}