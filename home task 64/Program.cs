/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


void recNum(int number)
{
    if (number >= 1)
    {
        Console.Write(number + " ");
        recNum(number - 1);
    }
    
}
recNum(N);

