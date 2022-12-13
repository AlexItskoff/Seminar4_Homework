/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);  

int sum = CalculateSum(n);
Console.WriteLine(sum);

int CalculateSum(int n)

    {
        int sum = 0;

         while (n != 0) 
        {

             sum = sum +n%10;      //sum += n % 10;  

             n = n/10;         //n /= 10;
          
        }

       return sum;


    }