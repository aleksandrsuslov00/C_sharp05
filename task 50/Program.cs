/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

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

int[,] numbers = fillAray(10,10);
PrintArray(numbers);
Console.WriteLine("Введите число для проверки: ");
int target = Convert.ToInt32(Console.ReadLine());
Console.Clear();

void searchNumber(int[,] arrayToPrint, int target)
{
    int count = 0; //счетчик для подсчёта повторов числа в массиве
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
       for (int j = 0; j < arrayToPrint.GetLength(1); j++)
       {
            if (arrayToPrint[i,j] == target)
            {
                count++;
            } 
       }
    }
    
    if (count > 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Число {target} есть в массиве");
        Console.ForegroundColor = ConsoleColor.White;
    
    }
    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Числа {target} нет в массиве");
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Число {target} присутствует в массиве {count} раз");
    Console.ForegroundColor = ConsoleColor.White;         
}

void ColorInArray(int[,] arrayToPrint, int target)
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
            //теперь в массиве совпадения будут выделенны цветом
            if (target == arrayToPrint[i,j])
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else Console.ForegroundColor = ConsoleColor.White;

            Console.Write(arrayToPrint[i,j] + "\t");
       }
       Console.WriteLine();
    }
}

searchNumber(numbers, target);
ColorInArray(numbers, target);



