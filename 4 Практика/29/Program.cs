/*Задача 29: Напишите программу, которая задаёт массив 
  из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
 */

int[] Array1()
{
    Console.WriteLine("Введите количество элементов массива: ");

    int num = int.Parse(Console.ReadLine());

    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"\nВведите элемент с индексом {i}:");
        array[i] = int.Parse(Console.ReadLine());
    }
Console.WriteLine("Выводимый массив:  [{0}]", string.Join(", ", array));
return array;
}

int[] result = Array1();
