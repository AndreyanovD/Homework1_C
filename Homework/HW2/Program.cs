Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber;
if (number1 >= number2)
{
    maxNumber = number1;
}
else maxNumber = number2;
if (number3 >= maxNumber)
{
    maxNumber = number3;
}
Console.Write($"Иаксимальное число: {maxNumber}");