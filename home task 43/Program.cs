/*
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());


if (k1 - k2 != 0) // <------ если иксы сократятся, тогда в знаменателе будет 0, а на ноль делить нельзя -> прямые не пересекутся т.е. параллельны;
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"b1 = {b1}, b2 = {b2}, k1 = {k1}, k2 = {k2}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Прямые пересекутся в точке с координатами (x = {x}; y = {y}) ");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine($"b1 = {b1}, b2 = {b2}, k1 = {k1}, k2 = {k2}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Прямые не пересекутся, соответственно они параллельны.");
    Console.ForegroundColor = ConsoleColor.White;
}    


/* Решаем через систему уравнений для вычисления координат точки пересечения прямых 
пример
y = 2x - 1
y = -3x + 1

y - y = 2x - 1 - (-3x + 1)  
y = -3x + 1
      
0 = 5x - 2
y = -3x + 1

5x = 2   
y = -3x + 1
      
x = 0.4
y = -3x + 1
 
x = 0.4
y = -3·(0.4) + 1 = -1.2 + 1 = -0.2
Точка пересечения двух прямых имеет координаты (0.4, -0.2)
*/
