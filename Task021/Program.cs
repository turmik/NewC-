﻿/*Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int z2 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($" {dist:f2} ");
