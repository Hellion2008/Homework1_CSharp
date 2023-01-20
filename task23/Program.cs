/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void GetCube(int n)
{
  int i = 1;
  int num = 0;
  
  while (i < n)
  {
    num = (int) Math.Pow(i, 3);
    Console.Write(num + ", ");
    i++;
  }
  Console.WriteLine(Math.Pow(i, 3));
}

int GetNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int N = GetNumber("Enter number N");

GetCube(N);
