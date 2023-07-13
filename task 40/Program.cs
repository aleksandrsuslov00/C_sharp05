/*
Задача 40.
Напишите программу, которая принимает 3 числа 
и проверяет может ли сущетсвовать треугольник 
со сторонами такой длины.
*/

bool IsTriangleExist (int sideA, int sideB, int sideC)
{
    if ((sideA + sideB > sideC) 
    && (sideB + sideC > sideA) 
    && (sideA + sideC > sideB))
        return true;
    return false;
}
Console.WriteLine("Укажите сторону А");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите сторону B");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите сторону C");
int sideC = Convert.ToInt32(Console.ReadLine());

if (IsTriangleExist(sideA, sideB, sideC))
{
    Console.WriteLine("Треугольник существует");
} 
else Console.WriteLine("Треугольник несуществует");


