// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void ControlNumber(int[,] array, int pos)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);
  if (pos < rows * cols)
  {
    Console.WriteLine($"i = {pos / cols} , j = {pos % cols}");
    Console.WriteLine(array[pos / cols, pos % cols]);
  }
  else Console.WriteLine($"Matrix hasn't got position {pos}"); 
}

void ShowMatrix(int[,] matrix)
{
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
  }
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int[,] GetMatrix()
{
  Console.WriteLine("Enter matrix MxN:");
  int m = GetNumber("M = ");
  int n = GetNumber("N = ");
  int[,] arr = new int[m,n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      arr[i,j] = new Random().Next(1,100);
    }
  }
  return arr;
}

int[,] matrix = GetMatrix();
ShowMatrix(matrix);
int controlPos = GetNumber("Enter position in matrix for control: ");
ControlNumber(matrix, controlPos);