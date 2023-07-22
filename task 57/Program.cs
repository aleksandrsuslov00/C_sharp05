/*
Создать частотный словарь элементов двумерного массива.
Он содержит информацию сколько раз встречается элемент входных данных.
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

void CountElementsInMatrix(int[,] matrix, Dictionary<int,int> counter)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (counter.ContainsKey(matrix[i, j]))
            {
                counter[matrix[i, j]]++;
            }
            else
            {
                counter.Add(matrix[i, j], 1);
            }
        }
    }
}



Dictionary<int, int> counter = new Dictionary<int, int>();
int[,] matrix = Fill2DAray(5,5,10);
Print2DArray(matrix);
CountElementsInMatrix(matrix, counter);
foreach (int key in counter.Keys)
{
    Console.WriteLine($"There are {counter[key]} in {key}'s");
}

