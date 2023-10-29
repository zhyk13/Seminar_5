// Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных
// равна -20.

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }

    return arr;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void SumPositiveAndNegativeNumber(int[] arr, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
    }
}

int[] array = new int[GetNumber("Введите колическво элементов массива: ")];


array = FillArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

SumPositiveAndNegativeNumber(array, out int sumPositive, out int sumNegative);
System.Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");

