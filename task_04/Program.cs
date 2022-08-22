// Найти расстояние между точками в пространстве 2D/3D
// Метод для генерации координат точек (с диапазоном от min до max)
void Coordinate(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while(i<position.Length)
    {
        position[i] = rand.Next(min,max);
        i++;
    }
}
// Метод для вывода на экран координат сгенерированных точек
void PrintPosition(int[] position)
{
    foreach(int element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Функция расчета отрезка между 2я точками
double DistancePoints(int[] point1, int[] point2)
{
    double dist = 0;
    for(int i = 0; i < point1.Length; i++)
    {
        dist = dist + (point1[i]-point2[i])*(point1[i]-point2[i]);
        Console.WriteLine($"разница между координатами: {(point1[i]-point2[i])}");
        Console.WriteLine($"возводим в квадрат разницу между координатами: {(point1[i]-point2[i])*(point1[i]-point2[i])}");
    }
    Console.WriteLine(dist);
    dist = Math.Round(Math.Sqrt(dist), 3, MidpointRounding.AwayFromZero);
    return dist;
}

Console.Write("Введите размерность 2D/3D (2 координаты или 3 координаты):");
int coordinate = int.Parse(Console.ReadLine());
int[] poinA = new int[coordinate];
int[] poinB = new int[coordinate];
Coordinate(poinA,-20,20);
Coordinate(poinB,-20,20);
PrintPosition(poinA);
PrintPosition(poinB);
Console.WriteLine($"Длина отрезка равна: {DistancePoints(poinA, poinB)}");
