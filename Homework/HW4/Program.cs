Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number / 2)
{
    Console.Write($"{count * 2} ");
    count++;
}