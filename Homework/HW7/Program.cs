void Palindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else Console.WriteLine("Число " + number + " НЕ является палиндромом");
}
string num = String.Empty;
Console.Write("Веедите пятизначное число: ");
num = Console.ReadLine();
Palindrom(num);