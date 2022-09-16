/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

//for run in range(n - 1):
//    for i in range(len(lst)):
//        for j in range(len(lst[i]) - 1):
//            if lst[i][j] > lst[i][j + 1]:
//                lst[i][j], lst[i][j + 1] = lst[i][j + 1], lst[i][j]
//
int[,] DescendRowElements(int[,]arr)
{
    for (int run = 0; run < arr.GetLength(1) - 1; run++)
    {
        int max = 0;
        for (int i = 0; i <arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) -1 ; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    max = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = max;
                }
            }
        }

    }
    return arr;
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
int[,] array = DescendRowElements(res);
PrintArray(array);