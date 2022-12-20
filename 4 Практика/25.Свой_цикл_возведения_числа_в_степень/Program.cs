/*
Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
и метод который возводит число A в натуральную степень B.
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
Не использовать Math.Pow() 
3, 5 => 243
2, 4 => 16                                                                       */

Console.Write($"Введите Первое число => ");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int a);
if (!isParsed1)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
}
else
{
    Console.WriteLine();
}


Console.Write($"Введите Второе число => ");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int b);
if (!isParsed2)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
}
else
{
    int j = a;
    for (int i = 1; i < b; i++)
    {
        j = j* a;
    }
        Console.WriteLine();
        Console.WriteLine($"Число {a} в степени {b} = {j}");
}