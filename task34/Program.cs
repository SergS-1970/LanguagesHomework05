/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

int numberEven = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0) numberEven ++;
}

Console.WriteLine($"[{String.Join("; ", array)}]");

Console.WriteLine($" Количество чётных элементов массива : {numberEven}");
