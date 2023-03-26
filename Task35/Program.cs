// Задача №35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива
// значения которых лежат в отрезке [10, 99].

int[] GetArray()
{
    Console.WriteLine("Введите  размер массива: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте пределы перебора случайных чисел. Нижняя граница: ");
    int randomLow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте пределы перебора случайных чисел. Верхняя граница: ");
    int randomHigh = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arraySize];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(randomLow,randomHigh);
    }
    return array;
}

int Selection(int[] array)// создаем метод для подсчета значений на заданном отрезке
{
    int sel = 0;
    for (int i = 0; i < array.Length; i++)
    if(array[i] >= 10 && array[i] < 100)
            sel++;
    return sel;
}
// запускаем программу вызовом всех нужных методов:
int[] array = GetArray();
Console.WriteLine(String.Join(" | ", array));
Console.WriteLine("Количество чисел на отрезке [10, 99] равно " + Selection(array));
