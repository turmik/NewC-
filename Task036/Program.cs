/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Write("Введите size: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите minValue: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите maxValue: ");
int maxValue = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue) /*new Random().Next(length, 100, 999)*/
{
    int[] res = new int[size];
    int result = 0;
    
    for(int i=1; i < size; i+=2);
    {
       res[i] = new Random().Next(minValue,maxValue+1);
       result += res[i];
    }
    return result;
}

int[] OddArr = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" , ", OddArr));
Console.WriteLine($"{result}");
