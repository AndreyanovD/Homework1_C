Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0) Console.Write($"Число {number} является чётным");
else Console.Write($"Число {number} является нечётным");