//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void Zadacha64()
{
    int m = 4;
    int n = 29;
    Slonik(m, n);
    Console.WriteLine();
}

void Slonik(int m, int n)
{
    int step = 1;
    if (m % 3 == 0)
    {
        Console.Write(m + " ");
        step = 3;
    }
    if (m + 3 > n) return;
    Slonik(m + 1 * step, n);

}

Zadacha64();