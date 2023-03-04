// 0. Напишите программу, которая на вход принимает число и
//    выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);
// int a = int.Parse(Console.ReadLine());

Console.WriteLine(a * a);