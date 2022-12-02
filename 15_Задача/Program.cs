/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

Zadacha15(number); 

void Zadacha15 (int currentNumber)
{
if    (number > 0 && number < 8) Console.Write("Да"); 
else  Console.Write("Нет");
if    (number < 0 && number > 8) Console.Write("Не является днем недели"); 
else  Console.Write("Нет");

}
