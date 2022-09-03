// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int[,] SpiralArray (int size)
{
    int max = size*size;
    int element = 0;
    int begin = 0;
    int [,] array = new int[size, size];
    while (element < max)
    {
        for(int i = begin; i < size; i++)
        {
            element++;
            array[begin,i] = element;
        }
        for(int i = begin + 1; i < size; i++)
        {
            element++;
            array[i, size -1] = element;
        }
        for(int i = size - 2; i >= begin; i--)
        {
            element++;
            array[size - 1, i] = element;
        }
        for(int i = size -2; i >= begin + 1; i--)
        {
            element++;
            array[i,begin] = element;
        }
        size -= 1;
        begin += 1;
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = SpiralArray(size);
PrintArray(array);