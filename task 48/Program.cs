/*
Задача 48.
Задайте двумерный массив размера m на n.
каждый элемент в массиве находится по формуле:
A[mn] = m + n
Выведите полученный массив в терминал.

m = 3, n = 4;
0 1 2 3
1 2 3 4
2 3 4 5
*/

Console.Clear();
int[,] Get2DArray (int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = i + j;
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

int[,] array = Get2DArray(5,7);
Print2DArray(array);
