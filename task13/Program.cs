// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool check = IsThreeDigits(num);
Console.WriteLine(check ? ThirdDigit(num) : "Третьей цифры нет");

bool IsThreeDigits(int val)
{
    return val > 99 || val < -99 ? true : false;
}

int ThirdDigit(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    number %= 10; 
    return number;
}