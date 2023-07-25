/*
напишите программу которая на вход принимает А и Б
и возводит А в целую степень Б с помощью рекрсии
*/

int AToPowB(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * AToPowB(a, b - 1);
    }
}
Console.WriteLine(AToPowB(2, 9));