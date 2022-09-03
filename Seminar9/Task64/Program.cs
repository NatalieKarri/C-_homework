// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
string ShowNumbers(int first, int last)
{
    if(first == last)
    {
    return first.ToString();
    }
    else
    {
        return (first + " " + ShowNumbers(first + 1, last));
    }
}

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int last = Convert.ToInt32(Console.ReadLine());
Console.Write(ShowNumbers(first, last));