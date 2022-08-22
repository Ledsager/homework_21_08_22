// По двум заданным числам проверять является ли одно квадратом другого
void SquaredSearch(int num1, int num2)
{
if (num1 * num1 == num2)
{
    Console.Write("число1 = " + num1 + " является квадратом числа2 = " + num2);
}
else if(num2 * num2 == num1)
{
    Console.Write("число2 = " + num2 + " является квадратом числа1 = " + num1);
}
else
{
    Console.Write("ни одно из чисел не является квадратом другого");
}
Console.WriteLine();
} 
Console.WriteLine("Введите чиcло1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чиcло2:");
int number2 = int.Parse(Console.ReadLine());
SquaredSearch(number1, number2);