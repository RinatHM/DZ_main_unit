using System;

class Program
{
    static void Main()
    {
        // Создание массива объектов
        object[] array = new object[] { "Hello", 2, "world", ":-)" };

        // Вывод элементов массива
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}