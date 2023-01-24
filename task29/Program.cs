/*
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void ShowArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] GetArray(int length)
{
  int[] array = new int[length];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100);
  }
  return array;
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int length = GetNumber("Enter length of array: ");
int[] array = GetArray(length);
ShowArray(array);
