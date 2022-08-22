// Задать номер четверти, показать диапазоны для возможных координат
void SectionPosition(int numbersection)
{
if (numbersection == 1)
{
    Console.WriteLine("Для первой четверти диапазон :(x > 0) и (y > 0)");
}
if (numbersection == 4)
{
    Console.WriteLine("Для четвертой четверти диапазон (x > 0) и (y < 0)");
}
if (numbersection == 3)
{
    Console.WriteLine("Для третьей четверти диапазон (x < 0) и (y < 0)");
}
if (numbersection == 2)
{
    Console.WriteLine("Для второй четверти диапазон (x < 0) и (y > 0)");
}
}
Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine());
SectionPosition(x);