//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
{
    double[] coords1 = GetFunction(1);
    double[] coords2 = GetFunction(2);
    double x = (coords2[1] - coords1[1]) / (coords1[0] - coords2[0]);
    double y = coords1[0] * x + coords1[1];
    Console.WriteLine($"Координаты пересечения прямых X = {x}, Y = {y}.");
}

double[] GetFunction(int n)
{
    double[] array = new double[2];
    Console.Write($"Введите коэффициент k{n} уравнения y=k{n}*x + b{n}: ");
    array[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите коэффициент b{n} уравнения y=k{n}*x + b{n}: ");
    array[1] = Convert.ToInt32(Console.ReadLine());
    return array;
}

Zadacha43();