//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int first, int last)
{
    if(first == last)
    {
    return first;
    }
    else
    {
        return (first + SumNumbers(first + 1, last));
    }
}

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int last = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма чисел от {first} до {last} = {SumNumbers(first, last)}");