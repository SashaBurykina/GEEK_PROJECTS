// ﻿// напишите программу, которая принимает на вход 2 числа и выдает
// // какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 ) 
{
    Console.WriteLine($"max = {num1}" );
}
else if(num1 == num2 ) 
{
    Console.WriteLine($"Вы ввели равнозначные числа! {num1} = {num2}" );
}
else 
{
    Console.WriteLine($"max = {num2}" );
}