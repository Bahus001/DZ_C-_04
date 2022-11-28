// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

int Sum(int num1, int res)
{
    for (int i = 0; num1 > 0; i++)
    {
        int num2 = num1 % 10;
        num1 = num1 / 10;
        res = res + num2;
    }
    return res;
}
int sum = Sum(number, result);
Console.WriteLine($"{number} -> {sum}");

