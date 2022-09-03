// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int FuncAkkerman(int first, int second)
{
    if (first == 0)
    return second + 1;
  else
    if ((first != 0) && (second == 0))
      return FuncAkkerman(first - 1, 1);
    else
      return FuncAkkerman(first - 1, FuncAkkerman(first, second - 1));
}

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана для чисел {first} и {second} = {FuncAkkerman(first, second)}");