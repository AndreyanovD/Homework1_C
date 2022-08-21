//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66()
{
    int m = 4;
    int n = 8;
    int sum = Slonik(m, n);
    Console.WriteLine(sum);
}

int Slonik(int m, int n, int sum = 0)
{
    sum = sum + m;
    if (m == n) return sum;
    return Slonik(m + 1, n, sum);
}

Zadacha66();
