// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] GetArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
    }
    return array;
}

int[] array = GetArray();
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0; 
int a = 0;
while (i < array.Length) 
{
    if (array[i] == number) 
    {
        a = number;
        break;
    }
    else i++;
}       

if (a == number) Console.WriteLine("Это число есть в массиве!");
else Console.WriteLine("Такого числа нет в массиве!");
