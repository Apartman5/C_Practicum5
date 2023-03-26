// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray()// создаем функцию для заполнения массива случайными числами
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int SumPositiv(int[] array)// создаем функцию сложения положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    if(array[i] > 0)
            sum += array[i];
    return sum;
}

int SumNegativ(int[] array)// создаем функцию сложения отрицательных элементов массива
{
    int sum = 0;
    foreach (int el in array)
        sum += el < 0 ? el : 0;//сумма плюс - проверка условия - элемент (тру) или 0 (фолс)
    return sum;
}

int[] array = GetArray();
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Сумма положительных элементов - {0}. Сумма отрицательных элементов - {1}", SumPositiv(array), SumNegativ(array));