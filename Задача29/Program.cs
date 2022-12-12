// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
PrintArray(array);
Console.WriteLine();
PrintArray(FillAray(array));
Console.WriteLine();
PrintArray(array);

int[] FillAray(int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 1000);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}