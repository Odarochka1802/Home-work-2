Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Этот день выходной?");

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("Нет");
}

CheckingTheDayOfTheWeek(dayNumber);

//Второй вариант через switch

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Этот день выходной?");
if (day < 8 && day > 0)
{
    switch (day)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Нет");
            break;
        case 6:
        case 7:
            Console.WriteLine("Да");
            break;

    }
}
else { Console.WriteLine("это вообще не день недели"); }