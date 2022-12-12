/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да    */


Console.Write("Введите размер массива: "); // Метод создания массива
int n = Int32.Parse(Console.ReadLine());         //Переменная которая задает размер массива

int[] arr = new int[n];                        //Задаем размер массива
for (int i = 0; i < n; i++)                  //Присваиваем значение каждой ячейки массива
{
    int k = Int32.Parse(Console.ReadLine()); // Значение задавать здесь
    arr[i] = k;
}


int[] reverse(int[] arr)
{
    int index = 0;
    int size = arr.Length;
    int reverseIndex = size - 1;
    int[] revArr = new int[arr.Length];
    while (index < size)
    {
        revArr[index] = arr[reverseIndex];
        index++;
        reverseIndex = reverseIndex - 1;
    }
    return revArr;
    
}

int[] reverseArray = reverse(arr);


Console.WriteLine();

Console.Write("Первый массив: ");
PrintArray(arr);

Console.Write("Второй массив: ");
PrintArray(reverseArray);


void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void chek(int[] arr, int[]reverseArray)
{
    if (arr == reverseArray)
    {
        Console.WriteLine("Данные значения являются Паллиндромом");
    }
    else
    {
        Console.WriteLine("Данные значения НЕ являются Паллиндромом");
    }
}
chek(arr, reverseArray);