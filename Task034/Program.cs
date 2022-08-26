/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите количество элементов массива : ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

int[] myArray(int size, int a, int b) /*new Random().Next(length, 100, 999)*/
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int[] evenMike(int[] mike)
{
    int MyRes = 0;
    for (int i = 0; i < mike.Length; i++)
    {
        if (mike[i] % 2 == 0)
        {
            MyRes++;
        }
    }
    return MyRes;
}

int[] arrCost = myArray(size, a, b);
Console.WriteLine($"[{String.Join(",", arrCost)}]");
Console.Write(evenMike(arrCost));


/*int[] myArray = GetArray(10, 100, 1000);
Console.WriteLine($"{GetArray(myArray)}");
Console.WriteLine($"{result}");*/