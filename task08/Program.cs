// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое, положительное число больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.Write($"Вы ввели отрицательное число! ");
}
else if (num == 0)
{
    Console.Write($"Число ноль не считается ни положительным, ни отрицательным! ");
}
else if (num == 1)
{
    Console.Write($"Нет чётных чисел в '{num}'! ");
}
else
{
    int count = 2;
    Console.Write($"Чётные: {count}");
    count += 2;
    while (count <= num)
    {
        Console.Write($", {count}");
        count += 2;
    }
}