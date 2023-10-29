// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// 

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }

//     return arr;
// }

// int GetNumber(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// //----------------------------------------------------------------

// int[] array = new int[GetNumber("Введите колическво элементов массива: ")];

// array = FillArray(array);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int number = GetNumber("Введите число: ");

// bool est=false;


// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i]==number)
//     {
//         est=true;
//         break;
//     }

// }

// System.Console.WriteLine(est);

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }

    return arr;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool isOk(int[] arr, int number)
{
    bool est = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            est = true;
            break;
        }
    }
    return est;
}

//----------------------------------------------------------------

int[] array = new int[GetNumber("Введите колическво элементов массива: ")];

array = FillArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int number = GetNumber("Введите число: ");
System.Console.WriteLine(isOk(array, number));


