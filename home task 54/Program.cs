/*
Задайте двумерный массив.
Напишите программу, которая
упорядочит по убыванию элементы каждой
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();
Console.WriteLine("Выберите количество строк: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите количество столбцов: ");
int colNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите диапозон возможных чисел в массиве: ");
Console.WriteLine("(от...) ");
int startNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("(до...) ");
int endNum = Convert.ToInt32(Console.ReadLine());

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

int[,] numbers = Fill2DAray(rowNumber,colNumber,startNum, endNum);
Print2DArray(numbers);
Console.WriteLine();


void OrderingNumbersInEachLine(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {   
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

OrderingNumbersInEachLine(numbers);
Print2DArray(numbers); 
Console.ForegroundColor = ConsoleColor.White;



