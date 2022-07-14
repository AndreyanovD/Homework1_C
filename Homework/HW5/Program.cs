//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
void Zadacha13()
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    string numStr = Convert.ToString(number);
    int len = numStr.Length;
    int numHelp = number;
    if (number < 100) Console.WriteLine("Третьей цифры нет");
    else
    {
        for (int count = 0; count < (len - 3); count++)
        {
            numHelp = numHelp / 10;
        }
        Console.WriteLine("Третья цифра заданного числа " + numHelp % 10);
    }
}

Zadacha13();