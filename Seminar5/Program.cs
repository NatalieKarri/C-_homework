Console.Clear();

int[] CreateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("Введите количество элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] FirstArray = CreateRandomArray(length, 100, 1000);
// ShowArray(FirstArray);

// int CountEvenNumber = 0;

// for (int i = 0; i < FirstArray.Length; i++)
// {
//     if (FirstArray[i]%2 == 0)
//     {
//         CountEvenNumber += 1;
//     }
// }Console.Write("Количество четных чисел в массиве: " + CountEvenNumber);

// Задача36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write("Введите количетсво элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] SecondArray = CreateRandomArray(length, 0, 100);
// ShowArray(SecondArray);

// int sumOddPosition = 0;

// for (int i = 0; i < SecondArray.Length; i++)
// {
//     if(i%2 != 0)
//     {
//         sumOddPosition += SecondArray[i];
//     }
// }
// Console.Write("Сумма элементов, стоящих на нечетных позициях: " + sumOddPosition);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количетсво элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] ThirdArray = CreateRandomArray(length, 0, 100);
ShowArray(ThirdArray);

int max = ThirdArray[0];
int min = ThirdArray[0];

for (int i = 0; i < ThirdArray.Length; i++)
{
    if(ThirdArray[i] < min)
    {
        min = ThirdArray[i];
    }
    else if(ThirdArray[i] > max)
    {
        max = ThirdArray[i];
    }
}
Console.Write($"Разница между максимальным и минимальным элементами массива равна: {max - min}");