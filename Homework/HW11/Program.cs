//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Zadacha27(int num)
{
    int summ = 0;
    while (num / 10 != 0)
    {
        summ += num % 10;
        num /= 10;
    }
    summ += num;
    Console.WriteLine("Сумма цифр числа равна " + summ);
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha27(number);