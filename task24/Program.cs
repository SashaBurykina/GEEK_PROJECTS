﻿﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

// 1+2+3+4+5+6+7+8

int SumNumbers(int num) // num = number
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}
