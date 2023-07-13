/*
Задача 44.
Неиспользуя рекурсию, выведете первые N чисел Фибоначчи. 
Первые два числа 0 и 1.
*/
Console.Clear();
Console.WriteLine("введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int number1 = 0;
int number2 = 1;

int fibi = 0;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(number1 + " ");
Console.Write(number2 + " ");

for (int i = 2; i < numberN; i++)
{
    fibi = number1 + number2;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(fibi + " ");
    number1 = number2;
    number2 = fibi;
}
Console.ForegroundColor = ConsoleColor.White;