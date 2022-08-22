//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation(int number, int degree)
// {
//   int result = 1;
//   for (int i = 1; i <= degree; i++)
//   {
//     result *= number;
//   }
//   return result;
// }
    
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine());
//     Console.Write("Введите степень: ");
//     int deg = int.Parse(Console.ReadLine());
//    int res =  Exponentiation(num, deg);
//     Console.WriteLine($"{num} в степени {deg} = {res}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumbers(int num)
//     {
//       int sum = 0;
//       while(num>0)
//       {
//         sum += num%10;
//         num = num/10;
//       }
//       return sum;
//     }

// Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());

//     int result = SumNumbers(number);
// Console.WriteLine($"Сумма всех цифр в числе = {result}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    void FillArray(int[] array)
    {
      int length = array.Length;
      for (int index = 0; index < length; index++)
      {
        array[index] =  new Random().Next(1,100);
        Console.Write(array[index] + ",");
      }
    }

   int[] arr = new int [8];
    FillArray(arr);