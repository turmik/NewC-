/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetArray(int size, int minValue, int maxValue) /*new Random().Next(length, 100, 999)*/
{
    int[] res = new int[size];
    int result = 0;
    
    for(int i=0; i < size; i++)
    {
        res[i] = new Random().Next(100,1000);
        if(res[i] % 2 == 0)
        {
          result++;
        }
    return result;
    }
}
int[] myArray = GetArray(10, 100, 1000);          
Console.WriteLine($"{GetArray(myArray)}");
Console.WriteLine($"{result}");