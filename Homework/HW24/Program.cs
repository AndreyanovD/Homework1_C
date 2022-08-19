//Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Zadacha61()
{
    int[,] firstMatrix = new int[3, 4];
    int[,] secondMatrix = new int[4, 3];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Данные матрицы не могут быть перемножены.");
    }
    else
    {
        FillArray(firstMatrix);
        FillArray(secondMatrix);
        int[,] matrixMultiple = Multiple(firstMatrix, secondMatrix);
        Console.WriteLine("Первая матрица:");
        PrintArray(firstMatrix);
        Console.WriteLine();
        Console.WriteLine("Вторая матрица:");
        PrintArray(secondMatrix);
        Console.WriteLine();
        Console.WriteLine("Результат перемножения матриц:");
        PrintArray(matrixMultiple);
    }
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

int[,] Multiple(int[,] m1, int[,] m2)
{
    int rows = m1.GetLength(0);
    int columns = m2.GetLength(1);
    int mult = m1.GetLength(1);

    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < mult; k++)
            {
                result[i, j] += m1[i, k] * m2[k, j];
            }

        }

    }
    return result;
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

Zadacha61();