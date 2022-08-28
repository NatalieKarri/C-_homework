// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    int[] CreateArray()
      {
      Console.Write("Введите количество элементов массива: ");
      int size = Convert.ToInt32(Console.ReadLine());
      int[] array = new int[size];
      for(int i = 0; i < size; i++)
        {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
      } 

    void ShowArray(int[] array)
      {
      for(int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
      }

    int countPositive(int[] array)
    {
      int count = 0;
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] > 0)
        {
          count += 1;
        }
      }
      return count;
    }
   int[] arr =  CreateArray();
    ShowArray(arr);
    int result = countPositive(arr);
    Console.WriteLine($"Количество положительных чисел {result}"); 