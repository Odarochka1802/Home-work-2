Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа {n}: {n / 10 % 10}");


Console.Write("Введи трёхзначное число: ");
string stroka = Console.ReadLine();
Console.WriteLine($"Вторая цифра числа {stroka}: {stroka[1]}");
