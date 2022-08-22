/*Задача 29: Напишите программу, которая задаёт массив из N элементов,
 заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]*/

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int[] arr(int N, int a, int b)

 {
    int [] res = new int [N];
    for (int i = 0; i < N; i++)
    {
        res[i] = new Random().Next(a,b+1);
    }
    return res;
}
int[] arr1  = arr(N,a,b);  
Console.WriteLine(String.Join(",", arr1));