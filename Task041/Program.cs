/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] GetArray(int M, int a, int b)
{
    int[] res = new int[M];
    for (int i = 0; i < M; i++)
    {
        res[i] = new Random().Next(a, b + 1);
    }
    return res;
}

int PositiveSum(int[] mike)
{
   int result = 0; 
   for (int i = 0; i < mike.Length; i++)
   if(mike[i] > 0)
   {
      result++;
   }
   return result;
}

Console.Write("Введите количество элементов массива M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

int[] arrCost =  GetArray( M, a, b);
Console.WriteLine($"[{String.Join(",", arrCost)}]");
Console.WriteLine(PositiveSum(arrCost)); 
