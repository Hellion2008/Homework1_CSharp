/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("Enetr the first number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Enetr the second number: ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum){
  Console.WriteLine("max = " + firstNum);
}
else {
  Console.WriteLine("max = " + secondNum);
}
