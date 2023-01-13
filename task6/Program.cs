/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Is it an even number?");
Console.Write("Enter your number: ");
int num = int.Parse(Console.ReadLine());

if (num%2 == 0)
  Console.WriteLine("YES");
else Console.WriteLine("NO");

