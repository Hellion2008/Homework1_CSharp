/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

string IsPalindrome(string number)
{
  int i = 0;
  char[] arr = number.ToCharArray();
  while (i < number.Length/2)
  {
    if ( arr[i] != arr[number.Length - 1 - i])
    {
      return "NO";
    }
    i++;
  }
  return "YES";
}

string GetNumber(string text)
{
  Console.Write(text);
  string number = Console.ReadLine();
  return number;
}

string num = GetNumber("Enter your number: ");

Console.Write("Is it Palindrome?  " + IsPalindrome(num));
