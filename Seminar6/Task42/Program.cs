//Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";
    while(num > 0)
    {
      result += num%2;
      num =  num/2;
    }
    
char[] inputarray = result.ToCharArray();
Array.Reverse(inputarray);
string output = new string(inputarray);


Console.WriteLine($"В двоичной системе = {output}");