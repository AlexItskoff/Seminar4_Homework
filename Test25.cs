﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine()!);



int Power(int a1, int b1)

{
     int result = a1;

      for (int i = 1; i < b1; i++)
        {
            result *= a1;
        }


    return result;
}



int Result = Power(a,b);

Console.WriteLine(Result);