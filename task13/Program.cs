/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Enter your number: ");
int num = int.Parse(Console.ReadLine());

if (num < 100) 
{
  Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
  while(num > 999)
  {
    num /= 10;
    Console.WriteLine(num);
  }
  int thirdNum = num % 10;
  Console.WriteLine($"{num} -> {thirdNum}");
}
