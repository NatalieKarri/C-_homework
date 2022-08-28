// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

void ShowArray(int[] array)
      {
      for(int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
      }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = arr[2] = 1;
    for(int i = 3; i < arr.Length; i++)
    {
      arr[i] = arr[i-1] + arr[i-2];
    }
   ShowArray(arr);