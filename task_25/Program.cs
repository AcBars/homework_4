/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using static System.Console;
Clear();
WriteLine("Введите число А");
int a= Convert.ToInt32(ReadLine());
WriteLine("Введите число В");
int b= Convert.ToInt32(ReadLine());
WriteLine($"Число {a} в степени {b} равно {Degree(a, b)}");
Degree(a, b);







int Degree(int a, int b)
{
    int result=1;
    for (int i=1; i<=b; i++)
    {
        
        result=result*a;
        
    }
    return result;
}