/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using static System.Console;
Clear();
WriteLine("Введите размер массива");
int a =Convert.ToInt32(ReadLine());

WriteLine($" [{String.Join(",", ManualArray(a))}]");
//ManualArray (a);






int [] ManualArray(int a)
{
    int [] result_array = new int[a];
    for(int i=0; i<a; i++)
    {
        WriteLine($"Введите {i+1} элемент массива.");
        result_array[i]=Convert.ToInt32(ReadLine());
        Clear();
    }

    return result_array;
}



