/*Задача 27: Напишите функцию и запустите ее, которая принимает
 на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int price = int.Parse(Console.ReadLine());

int NumSum(int N)
{
   int result = 0;
   while(price>0)
   {
    result = result + (price%10);
    price = price/10;
    
   }
   return result;
    
}
Console.WriteLine(NumSum(price));


/*int a = 4;
int b = a/10; 
Console.WriteLine($"{b}");*/


