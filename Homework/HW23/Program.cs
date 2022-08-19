//Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16

void Zadacha58()
{
    int[,] array = new int[10, 10];
    int count = 1;
    FillArray(array, 0, 0, count);
    PrintArray(array);
    Console.WriteLine();
}

//---------- Методы ----------
void FillArray(int[,] array, int i, int j, int count)
{
    array[i, j] = count;
    count++;
    int rows = array.GetLength(0) - 1;
    int columns = array.GetLength(1) - 1;
    if (j < columns && array[i, j + 1] == 0 && array[i + 1, j] == 0) FillArray(array, i, j + 1, count);
    if (i < rows && array[i + 1, j] == 0) FillArray(array, i + 1, j, count);
    if (j > 0 && array[i, j - 1] == 0) FillArray(array, i, j - 1, count);
    if (i > 0 && array[i - 1, j] == 0) FillArray(array, i - 1, j, count);
    if (j < columns && array[i, j + 1] == 0) FillArray(array, i, j + 1, count);

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

Zadacha58();