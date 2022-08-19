//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    int[,] array = new int[4, 4];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    int minSummStringIndex = SearchMinSummString(array);
    Console.Write($"Строка {minSummStringIndex} с наименьшей суммой элементов: ");
    int summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[minSummStringIndex, j] + "\t");
        summ += array[minSummStringIndex, j];
    }
    Console.WriteLine("(Сумма элементов равна " + summ + " )");
}

//---------- Методы ----------
void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
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

int SearchMinSummString(int[,] array)
{
    int minSumm = 100000000;
    int minSummRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempMinSumm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempMinSumm += array[i, j];
        }
        if (minSumm > tempMinSumm)
        {
            minSumm = tempMinSumm;
            minSummRow = i;
        }
    }
    return minSummRow;
}


Zadacha56();