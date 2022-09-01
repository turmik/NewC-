/*Задача 50. Напишите программу, которая на вход принимает позиции
 элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет*/

int[,] GetArray(int row, int col, int beginNum, int endNum)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().Next(beginNum, endNum + 1);

    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementPosition(int[,] arr, int m, int n)
{
    try
    {
        Console.WriteLine($"{arr[m, n]}");
    }
    catch
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

Console.Write("Число строк row= ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов col= ");
int col = int.Parse(Console.ReadLine());
Console.Write("beginNum= ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("int endNum= ");
int endNum = int.Parse(Console.ReadLine());
Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.WriteLine();
ElementPosition(myArray);