// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.


void Zadacha36()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    float[] array = new float[size];
    FillArray(array, -100, 100);
    PrintArray(array);
    Difference(array, size);
}

void FillArray(float[] array, int startNumber, int finishNumber)
{
    finishNumber++;
    for (int i = 0; i < array.Length; i++)
    {
        float rand = new Random().Next(startNumber * 100, finishNumber * 100);
        array[i] = rand / 100;
    }
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

void Difference(float[] array, int size)
{
    float minWalue = 100;
    float maxWalue = -100;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > maxWalue)
        {
            maxWalue = array[i];
        }
        if (array[i] < minWalue)
        {
            minWalue = array[i];
        }
    }
    Console.WriteLine($"Максимальный элемент {maxWalue}");
    Console.WriteLine($"Минимальный элемент {minWalue}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна {maxWalue - minWalue}");
}
Zadacha36();