/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

for (int i = 0; i < size; i++)
{
    var randomization = new Random().Next(-10000, 10000);
    
    //var selectionSign = new Random().Next(0,2) * 2 -1;
    //double numerator = new Random().NextDouble();
    //double denominator = new Random().NextDouble();
    //array[i] = Math.Round((numerator / denominator) * selectionSign, 4); 
    // СНАЧАЛА ТАК ХОТЕЛ ЗАДАТЬ ВЕЩЕСТВЕННЫЕ ЧИСЛА,
    // ПОТОМ РЕШИЛ, ЧТО ИСПОЛЬЗОВАННОГО В КОДЕ ВАРИАНТА ВПОЛНЕ ДОСТАТОЧНО ДЛЯ ДАННОЙ ЗАДАЧИ.

    array[i] = Math.Round(new Random().NextDouble() * randomization, 4);
}

Console.WriteLine($"[{String.Join("; ", array)}]");

double maxValue = array[0];
double minValue = array[0];

for (int i = 1; i < size; i++)
{
    if (array[i] > maxValue) maxValue = array[i];
    if (array[i] < minValue) minValue = array[i];
}

Console.WriteLine($" Макс. элемент массива : {maxValue}");
Console.WriteLine($" Мин.. элемент массива : {minValue}");

double differenceMaxMin = maxValue - minValue;
Console.WriteLine($" Разность макс. и мин. элементов массива : {differenceMaxMin}");