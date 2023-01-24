/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSum(int num)
{
  int sum = 0;
  while (num !=0)
  {
    sum += (num % 10);
    num /= 10;
    //Console.WriteLine($"{num} ---------------- {sum}");
  }
  return sum;
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = GetNumber("Enter your number: ");

int result = GetSum(number);
Console.WriteLine($"{number} -> {result}");
