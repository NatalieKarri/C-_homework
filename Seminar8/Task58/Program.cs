// Задача 58: Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
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

Console.Write("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillArray(row1, column1);

Console.Write("Введите количество строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = FillArray(row2, column2);

PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);

static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
    {       
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
           
           throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
 
        var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
 
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
 
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
 
        return matrix3;
    }

    System.Console.WriteLine();
int[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
    PrintArray(matrix3);