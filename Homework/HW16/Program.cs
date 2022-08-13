//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.Write("Введите количество чисел, которые Вы хотите ввести: ");
    int count = Convert.ToInt32(Console.ReadLine());
    PositiveCount(count);
}

void PositiveCount(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} положительных чисел.");
}

Zadacha41();

