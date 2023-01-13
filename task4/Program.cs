/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Enter three numbers.");
Console.Write("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int thirdNum = int.Parse(Console.ReadLine());

int max = firstNum;
if (secondNum > max)
  max = secondNum;
if (thirdNum > max)
  max = thirdNum;

Console.WriteLine("max = " + max);
