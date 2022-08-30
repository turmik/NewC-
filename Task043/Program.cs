/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double[,] GetArray (int m, int n)
{
    double[,] res = new double[2, 2] {{k1, b1},{k2,b2}};
    for (int i = 0; i < 2; i++)
       for(int j =0; j < 2; j++)
    {
        res[i,j] = new Random().Next();
    }
    return res;
}

void Point(int k1, int k2, int b1, int b2)
{
    double y1 = 0;
    double y2 = 0;
    double x = 0;
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 -k2);
        y= k1 * x + b1;
        Console.WriteLine($"({y}; {x})");
        
    }
    else Console.WriteLine($"Прямые не пересекаются");

    Console.WriteLine($"({y}; {x})");
}
Console.WriteLine("Введите к1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите к2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Point(k1, k2, b1, b2); 



 