/*
Задача 51.
Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали
С индаксами [0,0] [1,1] [2,2] и т.д.

*/
Console.Clear();
int[,] GetRandom2DArray (int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
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

int SumOfDiagonalElemets (int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i,j];
            }
        }
    }
    return sum;
}

int[,] array = GetRandom2DArray(5,6,5);
Print2DArray(array);
int sum = SumOfDiagonalElemets(array);
Console.WriteLine();
Console.Write($"Сумма элементов на диагонали равна: {sum}");
