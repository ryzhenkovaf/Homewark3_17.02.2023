// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int a1 = number / 10000;
int a2 = number / 1000 - (a1*10);
int a3 = number / 100 - ((a1*100)+(a2*10));
int a4 = number / 10 - ((a1*1000)+(a2*100)+(a3*10));
int a5 = number % 10;

if (number >= 10000 && number < 100000)
    {
        if (a2 == a4 && a1 == a5)
        {
            Console.WriteLine($"{number} - палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - НЕ палиндром");
        }
    }
else
{
    Console.WriteLine("Введено не пятизначное число ");
}
