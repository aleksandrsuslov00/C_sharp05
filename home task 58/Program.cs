/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
Console.WriteLine("Введите число строк для 1-й матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для 1-й матрицы и число строк для 2-й матрицы : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для 2-й матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < 1 || b < 1 || c < 1 )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Используйте числа больше 1 ");
}
Console.Clear();

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
       Console.Write($"[{i}]\t");
    }
    
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
       Console.Write($"[{i}]\t");
       for (int j = 0; j < arrayToPrint.GetLength(1); j++)
       {
           Console.Write(arrayToPrint[i,j] + "\t");
       }
       Console.WriteLine();
    }
}

void Fill2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

int[,] first_Matrix = new int[a, b];
Console.ForegroundColor = ConsoleColor.DarkYellow;
Fill2DArray(first_Matrix);
Console.WriteLine("1 матрица: ");
Print2DArray(first_Matrix);
Console.WriteLine();

int[,] second_Matrix = new int[b, c];
Console.ForegroundColor = ConsoleColor.Green;
Fill2DArray(second_Matrix);
Console.WriteLine("2 матрица: ");
Print2DArray(second_Matrix);
Console.WriteLine();

int[,] result_Matrix = new int[a, c];
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Результирующая матрица: ");

void ProductMatrix(int[,] Matrix_a, int[,] Matrix_b)
{
  for (int i = 0; i < result_Matrix.GetLength(0); i++)
  {
    for (int j = 0; j < result_Matrix.GetLength(1); j++)
    {
      int product = 0;
      for (int k = 0; k < Matrix_a.GetLength(1); k++)
      {
        product += Matrix_a[i, k] * Matrix_b[k, j];
      }
      result_Matrix[i, j] = product;
    }
  }
}

ProductMatrix(first_Matrix, second_Matrix);
Print2DArray(result_Matrix);
Console.ForegroundColor = ConsoleColor.White;

