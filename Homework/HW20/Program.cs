//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    double[,] array = new double[5, 5];
    FillArray(array);
    PrintArray(array);
    double[] averageWalue = Average(array);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < averageWalue.Length; i++)
    {
        Console.Write(averageWalue[i] + "\t");
    }
}

void FillArray(double[,] array)
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

void PrintArray(double[,] array)
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

double[] Average(double[,] array)
{
    double[] averWalue = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)            // Это счетчик столбцов
    {
        for (int i = 0; i < array.GetLength(0); i++)        // Это счетчик строк
        {
            averWalue[j] += array[i, j];
            if (i == array.GetLength(0) - 1)
            {
                averWalue[j] = averWalue[j] / array.GetLength(0);
            }
        }
    }
    return averWalue;
}

Zadacha52();