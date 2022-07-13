Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.Write($"Число {number1} меньше, чем {number2}");
}
else if (number1 > number2)
{
    Console.Write($"Число {number1} больше, чем {number2}");
}
else Console.Write("Числа равны");
