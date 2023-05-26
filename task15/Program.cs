// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int Weekday)
{
    if (Weekday > 5)

    {
        return true;
}
    return false;
}

bool ValiDayteWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
         return true;
    }
     Console.WriteLine("Это не день недели!");
     return false;
 }

 int Weekday = Promt("Введите день недели >");
 if (ValiDayteWeekday(Weekday))
 {
   if (IsWeekend(Weekday))
   {
    Console.WriteLine("Наконец-то выходной");
   }
   else
   {
    Console.WriteLine("Придётся поработать");
   }
 }