//void Distance(int x1, int x2, int x3, int y1, int y2, int y3)

int Sqr(int coord1, int coord2)
{
    int sqr = (coord1 - coord2) * (coord1 - coord2);
    return sqr;
}


Console.Write("Введите координату Х первой точки: ");
int firstCoordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int firstCoordY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int firstCoordZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х второй точки: ");
int secondCoordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int secondCoordY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int secondCoordZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Sqr(firstCoordX, secondCoordX) + Sqr(firstCoordY, secondCoordY) + Sqr(firstCoordZ, secondCoordZ));
Console.WriteLine("Расстояние между точками " + distance);