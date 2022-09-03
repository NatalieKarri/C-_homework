// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
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

int FindMinRow(int[,] matrix)
{
    int sum = int.MaxValue;
    int minInd = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           temp += matrix[i,j];
        }
        if (temp < sum)
        {
            sum = temp;
           minInd = i;
        }
    }
    return minInd;
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(row, column);
PrintArray(array);
System.Console.WriteLine();
int answer = FindMinRow(array);
System.Console.WriteLine($"Наименьшая сумма в {answer+1} строке");