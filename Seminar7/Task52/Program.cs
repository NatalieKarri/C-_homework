// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
int[,] FillArray(int rows, int columns)
{
int[,] matrix = new int[rows, columns];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}
return matrix;
}

void PrintArray(int [,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}\t");
    } 
    Console.WriteLine();
}
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArray(row, column);
PrintArray(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    int sum = 0;
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
        average = (double) sum / matrix.GetLength(0);  
    }
    
    Console.Write($"{average:f1}\t");
}