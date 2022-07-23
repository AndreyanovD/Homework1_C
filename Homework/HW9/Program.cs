void Cube(int n)
{
    int i = 1;
    for (i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write("\b\b" + " ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);