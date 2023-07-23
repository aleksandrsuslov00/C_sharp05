/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int[,] Fill2DAray(int rowNumber, int colNumber, int startNum, int endNum)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i,j] = new Random().Next(startNum, endNum);
        }
    }
    return array;
}

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

int[,] numbers = Fill2DAray(5,5,0,10);
Print2DArray(numbers);
Console.WriteLine();

int SumLineElements(int[,] array, int i)
{
  int sum = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i, j];
  }
  return sum;
}

int count = 0;
int sum = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int temp = SumLineElements(numbers, i);
  if (sum > temp)
  {
    sum = temp;
    count = i;
  }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {count}-я строка");
Console.WriteLine($"Сумма в этой строке: {sum}");

