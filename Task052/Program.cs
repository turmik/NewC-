/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        {
        for (int j = 0; j < n; j++)
           {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
           }
        }   
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }    
        Console.WriteLine();
    }
}

void AverageColumsSum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        result += arr[i, j];
        Console.Write($"{result/arr.GetLength(1):f1}, ");
    }
}

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());
Console.Write("minValue= ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("maxValue= ");
int maxValue = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
AverageColumsSum(myArray);



