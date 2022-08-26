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
int PartNumber;
//Цикл с постусловием
do
{
    //Приглашение пользователю
    Console.Write("Введите номер четверти (1-4):");
     /*
    * Получение введенного с клавиатуры значения,
    * введенное значение сохраняется в переменную PartNumber
    */
    while(!int.TryParse(Console.ReadLine(), out PartNumber))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите номер четверти (1-4): ");
    //num = Convert.ToInt32(NumberDay);
} while ((PartNumber > 4) || (PartNumber < 1));
SectionPosition(PartNumber);