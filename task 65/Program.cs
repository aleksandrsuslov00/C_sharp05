/*
Задайте значения М и N 
Напишите программу которая
выведет все натуральные числа от М до N

M = 1; N = 5 -> "1,2,3,4,5"
M = 4; N = 8 -> "4,5,6,7,8"
*/
Console.WriteLine("Введите число N: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int end = Convert.ToInt32(Console.ReadLine());

void RecursionNumberNM(int start, int end)
{
    if (start > 1 && end > 1)
    {
        if (start <= end)
        {
            Console.Write(start + " ");
         RecursionNumberNM(start + 1, end);
        }
    }
    else (Console.WriteLine("Введено не натуральное число "));
}

RecursionNumberNM(start, end);