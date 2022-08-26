/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Write("Введите size: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

int[] myArray(int size, int a, int b) 
{
    int[] res = new int[size];
    
    for(int i=1; i < size; i++);
    {
       res[i] = new Random().Next(a, b+1);
    }
    return res;
}

int OddMike(int[] man)
{
    int oddRes = 0;
    for (int i = 1; i < man.Length; i += 2)
    {
        oddRes += man[i];
    }
    return oddRes;
}

int[] array = myArray(size, a, b);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.Write(OddMike(array));
