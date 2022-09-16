/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка*/


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

void MinRow(int[,] arr)
{
    int min = 0;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int res = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res += arr[i, j];
            if (i == 0)
                sum = res;
        }
        if (res < sum)
        {
            sum = res;
            min = i;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {min} строка");
}


Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте диапазон случайных чисел:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int[,] res = GetArray(m, n, min, max);
PrintArray(res);
Console.WriteLine();
MinRow(res);
