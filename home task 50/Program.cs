/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();

int[,] fillAray(int rowNumber, int colNumber)
{
    int[,] array = new int [rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i, j] = new Random().Next(-10,10);
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

void ColorInArray(int[,] arrayToPrint, int row, int col)
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
            if (i == row && j == col)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write(arrayToPrint[i,j] + "\t");
       }
       Console.WriteLine();
       Console.ForegroundColor = ConsoleColor.White;
    }
}

int[,] numbers = fillAray(5,5);
PrintArray(numbers);

Console.WriteLine("Выберите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (row > numbers.GetLength(0)-1 || col > numbers.GetLength(1)-1 || row < 0 || col < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Такого элемента нет, либо числа введены неправильно.");
}
else
{ 
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Строка: {row}, столбец: {col}");
    Console.ForegroundColor = ConsoleColor.White;
}

ColorInArray(numbers, row, col);
