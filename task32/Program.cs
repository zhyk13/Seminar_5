// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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



int[] array = new int[GetNumber("Введите колическво элементов массива: ")];

array = FillArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    array[i]=-array[i];
}

System.Console.WriteLine($"[{string.Join(", ", array)}]");