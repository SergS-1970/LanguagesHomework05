/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];

int sumElementsOddPositions = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99,100);
    if (i % 2 == 1) sumElementsOddPositions +=array[i];
}

Console.WriteLine($"[{String.Join("; ", array)}]");

Console.WriteLine($" Сумма элементов с нечётными индексами: {sumElementsOddPositions}");