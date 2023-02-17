// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{ 
    if (number[2] == number[4] && number[1] == number[5])
    {
        Console.Write($"{number} палиндром");
    }
    else
    {
        Console.Write($"{number} не палиндром");
    }
}
