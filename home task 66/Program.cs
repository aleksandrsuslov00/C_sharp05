/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int recursion(int m, int n)
{
    int sum = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m = m + 1;
        sum = m + recursion(m, n);
        return sum;
    }
}

void sumOfElements(int m, int n)
{
    Console.Write($"Cуммa натуральных элементов = {recursion(m - 1, n)}");
}

if (m > 0 && n > 0) 
{
    sumOfElements(m, n);
}
else
    Console.WriteLine("Введено не натуральное число. ");