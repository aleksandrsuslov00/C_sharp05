/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
// создать массив
int[] getRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = prompt($"Введите {i} элемент массива: ");
    }
    return result;
}

//метод вывода массива в терминал
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{i}] = {array[i]}");        
    }
}

// пользователь пишет числа в консоль
int prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

//получаем массив в столбик
int lenght = prompt("Введите число M в консоль. Это будет размер массива. ");
int[] array = getRandomArray(lenght);
PrintArray(array);


//ищу сумму положительных чисел
int getSumOfPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine($"Введено {getSumOfPositiveNumbers(array)} числа/чисел больше 0");
