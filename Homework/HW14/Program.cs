//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha36()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array, -100, 100);
    PrintArray(array);
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine("Сумма нечётных элементов массива равна " + sum);
}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    finishNumber++;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "  ");
    }
    Console.WriteLine();
}

Zadacha36();