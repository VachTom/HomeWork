/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/


int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некоретное значение");
        return -1;
    }
}

double x1 = InputInt();
double y1 = InputInt();
double z1 = InputInt();
double x2 = InputInt();
double y2 = InputInt();
double z2 = InputInt();

//прописали методом Более красиво
double GetDistanceBetweenTwoPoints1(double x1, double x2, double y1, double y2, double z1, double z2)
{                           
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}
double result = GetDistanceBetweenTwoPoints1(x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);
