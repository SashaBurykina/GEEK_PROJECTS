﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int FirstDigit(int num)
{
    int number = num / 10000;
    return number;
}

int SecondDigit(int num)

{
    int number = num / 1000 % 10;
    return number;
}

int FourDigit(int num)

{
    int number = num / 10 % 10;
    return number;
}

int FiveDigit(int num)
{
    int number = num % 10;
    return number;
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 || number < -10000)
{


    if (FirstDigit(number) == FiveDigit(number) && SecondDigit(number) == FourDigit(number))
    {
        Console.WriteLine($"{number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"{number} НЕ является полиндромом");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
    return;
}