// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string message)
{
System.Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num)
{
if (num == 0) return 0;
return num % 10 + SumDigits(num / 10) ;
}


int number = EnterNumber("Enter number");
Console.WriteLine("Сумма цифр числа:");
Console.WriteLine(SumDigits(number));