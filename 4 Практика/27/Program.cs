/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


// тело программы
Console.Write($"Введите число: ");
int number = InputInt();

// обьявление методов
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели некоректную информацию.");
        return -1;
    }
}

int result = 0;
while (number > 0)
{
    int sum = number % 10;
    number = number / 10;
    result = result + sum;
}

Console.WriteLine($"Сумма цифр в числе: {result}");
