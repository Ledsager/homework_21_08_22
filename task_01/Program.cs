//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
void DayWeek(int day)
{
if (day == 6 || day == 7)
{
    Console.Write("это выходной");
}
else
{
    Console.Write("это рабочий день недели");
}
}
/*Console.WriteLine("Введите номер дня недели (1-7):");
int numberday = int.Parse(Console.ReadLine());
DayWeek(numberday);
*/

int NumberDay;
//Цикл с постусловием
do
{
    //Приглашение пользователю
    Console.Write("Введите номер дня недели (1-7):");
     /*
    * Получение введенного с клавиатуры значения,
    * введенное значение сохраняется в переменную NumberDay
    */
    while(!int.TryParse(Console.ReadLine(), out NumberDay))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите номер дня недели (1-7): ");
    //num = Convert.ToInt32(NumberDay);
} while (((int)NumberDay > 7) || ((int)NumberDay < 1));
DayWeek(NumberDay);





/*Console.WriteLine("Введите номер дня недели (1-7):");

//string NumberDay = "";
int NumberDay;
int num;
//Цикл с постусловием
do
{
    //Приглашение пользователю
    Console.Write("Введите номер дня недели (1-7):");
    
    // Получение веденной с клавиатуры строки,
    // введенная строка сохраняется в переменную NumberDay
    
    //NumberDay = Console.ReadLine();
    while(!int.TryParse(Console.ReadLine(), out NumberDay))
    Console.Write("Неверный ввод! \nВведите номер дня недели (1-7): ");
     //Вывод введенной строки
    //Console.WriteLine("Пользователь ввел строку: " + NumberDay);
    num = Convert.ToInt32(NumberDay);
} while (((int)num > 7) || ((int)num < 1));
*/