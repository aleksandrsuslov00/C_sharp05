/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
int[,] fillAray(int rowNumber, int colNumber)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}
int[,] numbers = fillAray(4,4);
int temp = 1;
int i = 0;
int j = 0;
while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
{
  numbers[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= numbers.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > numbers.GetLength(1) - 1)
    j--;
  else
    i--;
}
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
PrintArray(numbers);
