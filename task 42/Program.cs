/*
Задача 42.
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
*/

Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());

int binary = 0;
int shift = 1; //сдвигает результаты
while(value != 0)
{
    binary += value % 2 * shift; // или binary = binary + value / 2 * shift;
    shift *= 10;
    value /= 2;
}

Console.WriteLine(binary);
