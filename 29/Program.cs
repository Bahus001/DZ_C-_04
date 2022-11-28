// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);

    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}
FillArray(array);
PrintArray(array); 