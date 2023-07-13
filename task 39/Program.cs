/*
Задача 39.
Напишите программу, которая перевернет одномерный массив.
*/

//метод генерации массива с рандомными числами(элементами)
int[] GenerateArray(int lenght, int start, int end)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1); 
    }
    return array;
}

//метод вывода массива в терминал
void PrintArray (int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]"); 
}


//метод перевернутого массива
int[] reverseArray (int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan; 
int[] array = GenerateArray(5, -100, 100);
PrintArray(array, "Начальный массив");
Console.ForegroundColor = ConsoleColor.White; 
Console.WriteLine("==========================");
Console.ForegroundColor = ConsoleColor.DarkYellow;
int[] arrayRev = reverseArray(array);
PrintArray(arrayRev, "Перевёрнутый массив");














