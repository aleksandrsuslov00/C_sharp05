/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
int[,] FillArray(int rowNumber, int colNumber)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arrayToPrint)
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

Console.WriteLine("Выберите количество строк: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите количество столбцов: ");
int colNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] numbers = FillArray(rowNumber, colNumber);
PrintArray(numbers);
Console.Write("Среднее арифметическое каждого столбца равно: ");

void averageCol(int[,] arrayToPrint)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            average = (average + arrayToPrint[i, j]); 
        }
        average = average / rowNumber;
        Console.Write($"{average}; ");
    }
}

averageCol(numbers);

