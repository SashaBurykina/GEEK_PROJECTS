﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = IsThreeDigits(num);
Console.WriteLine(res ? SecondDigit(num) : "Вы ввели не трёхзначное число: ");

string SecondDigit(int number)
{
    int res = number / 10;
    res = res % 10;
    return $"Вторая цмфра этого числа: {res}";
}


bool IsThreeDigits( int val)
{
    return val > 99 && val < 1000 || val < -99 && val > -1000 ? true : false;
}
