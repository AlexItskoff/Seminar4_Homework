/*Задача 29: Напишите программу, которая принимает на вход числа n, min, max.
 Затем генерирует массив размером n и заполняет его случайными числами 
 в диапазоне от min до max.

5, 1, 19 -> [1, 2, 5, 7, 19]

3, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Введите число. Оно определит длину массива");
int n = int.Parse(Console.ReadLine()!);
if (n<0)
{
    n = -n;
    Console.WriteLine(n);              // делаем число n положительным
}

Console.WriteLine("Введите меньшее число. Оно определит нижнюю гранцу массива");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите большее число. Оно определит верхнюю границу массива");
int max = int.Parse(Console.ReadLine()!);

if (min>=max)

{
   Console.WriteLine(" Wrong numbers. Min means minimum! Try once more!");  // 
   // объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
}


int[] GenerateArray()

{

     int[] array = new int[n];

     
   for(n=0; n< array.Length; n++)
  {
     array[n] = new Random().Next( min,  max);

  }
    return array;

}

void PrintArray(int[] array)
{
   for(n=0; n< array.Length; n++)

   {
   Console.Write(array[n] + "  ");
   }

    Console.WriteLine();
}



string arrayToString(int[] array)

{
     string str = "";
     for(n=0; n<array.Length; n++)
        {

            str += array[n] + "  ";


        }

     return str;
}




int[] firstArray = GenerateArray();
PrintArray(firstArray);

int[] secondArray = GenerateArray();
Console.WriteLine(arrayToString(secondArray));



