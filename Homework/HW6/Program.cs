﻿//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

void Week()
{
    Console.Write("Введите день недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота (выходной)");
            break;
        case 7:
            Console.WriteLine("Воскресение (выходной)");
            break;
        default:
            Console.WriteLine("Неправильный ввод");
            break;
    }

}

Week();