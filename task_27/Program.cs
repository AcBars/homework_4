/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using static System.Console;
Clear();
WriteLine("Введите число");
int number=Convert.ToInt32(ReadLine());
WriteLine($"Сумма цифр числа {number} равна {SumNumber(number)}");






int SumNumber(int a)
{
    int result=0;
    while (a>=1)
    {
        result=result+a%10;
        a=a/10;

    }
    return result;
}