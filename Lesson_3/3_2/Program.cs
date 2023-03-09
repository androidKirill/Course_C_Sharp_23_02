﻿// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

double Line3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

double x_1 = double.Parse(Console.ReadLine()!);
double y_1 = double.Parse(Console.ReadLine()!);
double z_1 = double.Parse(Console.ReadLine()!);
double x_2 = double.Parse(Console.ReadLine()!);
double y_2 = double.Parse(Console.ReadLine()!);
double z_2 = double.Parse(Console.ReadLine()!);

// 3, 6, 8, 2, 1, -7
// 7, -5, 0, 1, -1, 9
Console.WriteLine(Line3D(x_1, y_1, z_1, x_2, y_2, z_2));