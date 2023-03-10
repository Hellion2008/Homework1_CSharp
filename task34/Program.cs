/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void ShowArray(int[] arr)
{
  Console.Write("[" + string.Join(", ", arr) + "]");
}

int CalculateCountOfEven(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) count++; 
  }
  return count;
}

int[] GenerateArray(int size)
{
  int[] arr = new int[size];
  for(int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(100, 1000);
  }
  return arr;
}

int GetLength(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = GetLength("Enter the length of array: ");
int[] array = GenerateArray(number);
ShowArray(array);
Console.Write(" -> " + CalculateCountOfEven(array));