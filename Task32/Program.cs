// Задача 32: 
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] array = GetArray();
Console.WriteLine("First array: ");
Console.WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
Console.WriteLine("Second array: ");
Console.WriteLine(String.Join(" ", array));