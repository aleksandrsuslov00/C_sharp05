/*
Задача 55.
Задайте двумерный массив. Напишите программу, которая заменяет 
на столбцы. В случае, если это невозможно, программа должна 
вывести сообщения для пользователя. Например:
1 4 7 2
5 9 2 3 
8 4 2 4
5 2 6 7
В итоге получается:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

int[,] Fill2DAray(int rowNumber, int colNumber, int deviation)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i,j] = new Random().Next(0, deviation);
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


int[,] RowsToColumns(int[,] array)
{  
    int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) != array.GetLength(1))
    {
        return matrix;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                matrix [j,i] = array [i,j];
        }
    }
    return matrix;    
}


int[,] matrix = Fill2DAray(5,5,10);
int[,] newMatrix = RowsToColumns(matrix);

Print2DArray(matrix);
Console.WriteLine();

Print2DArray(newMatrix);
