//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

void Zadacha68()
{
    double m = 3;
    double n = 5;
    double result = Akkerman(m, n);
    Console.WriteLine(result);
}

double Akkerman(double m, double n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return 0;
}

Zadacha68();