// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16


Console.WriteLine("Введите число ");
Console.Write("А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
Console.Write("В ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;

int Sum(int a1, int b1, int c1)
{
    for (int i = 1; i < b1; i++)
    {
        c1 = c1 * a1;
    }
    return c1;
}
int sum = Sum(a, b, c);
Console.WriteLine($"{a}, {b} -> {sum}");