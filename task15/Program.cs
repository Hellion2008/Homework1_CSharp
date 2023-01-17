/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Enter the number (day) of the week: ");
int day = int.Parse(Console.ReadLine());

if (day > 0 && day < 8)
{
  if (day > 0 && day < 6)
  {
    Console.WriteLine($"{day} -> нет");
  }
  else
  {
    Console.WriteLine($"{day} -> да");
  }
}

