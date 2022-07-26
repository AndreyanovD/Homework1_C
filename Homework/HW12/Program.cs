//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит отсортированный по модулю массив.

void Zadacha29()
{
    int[] array = new int[8];
    int i = 0;
    int j = 0;
    for (i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
    for (j = 1; j < array.Length; j++)
    {
        for (i = array.Length - 1; i > 0; i--)
        {
            if (Math.Abs(array[i]) < Math.Abs(array[i - 1]))
            {
                int temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
            }
        }
    }
    for (j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "  ");
    }
}

Zadacha29();