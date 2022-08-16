//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    int[,] array = new int[5, 5];
    FillArray(array);
    Console.Write("Введите индекс строки элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());
    PrintArray(array);
    if (row > array.GetLength(0) - 1 || column > array.GetLength(0) - 1)
    {
        Console.WriteLine("Такого элемента не существует.");

    }
    else Console.WriteLine($"Значение элемента массива [{row},{column}] = " + array[row, column]);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha50();