// double Distance(double x1, double y1, double x2, double y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// }

// Console.WriteLine(Distance(3, 6, 2, 1));
// Console.WriteLine(Distance(7, -5, 1, -1));

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine()!);
int result = GetThirdDigit(number);


int GetThirdDigit(int number)
{   
    int i = 0;
    while (number > 999)
    {
        number /= 10;
        i = number % 10;
    }
    return i;
}


if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
    Console.WriteLine($"Третья цифра число {result}");