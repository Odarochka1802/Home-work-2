void function(string n)
{
    if (n.Length > 2)
    {
        Console.Write("Третья цифра: " + n[2]);
    }
    else
    {
        Console.Write("Третьей цифры нет!");
    }

}

Console.Write("Введи число: ");
string n = Console.ReadLine();
function(n);

