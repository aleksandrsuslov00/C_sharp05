/*
Задайте двумерный массив.
Напишите программу, которая поменяет местами 
первую и последнюю строчку массива.

из:
1 4 7 2
5 9 2 3
8 4 2 4

нужно сделать:
8 4 2 4 
5 9 2 3 
1 4 7 2 
*/

int[,] Fill2DAray(int rowNumber, int colNumber, int deviation)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i,j] = new Random().Next(-deviation, deviation + 1);
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

void replace(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp; 
    }
}

int[,] rndNumbers = Fill2DAray (3, 4, 10);
Print2DArray(rndNumbers);

replace(rndNumbers);
Print2DArray(rndNumbers);