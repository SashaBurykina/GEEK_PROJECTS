// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 10000)
{


    if (FirstDigit == FiveDigit && SecondDigit == FourDigit)
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