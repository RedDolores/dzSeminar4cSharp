// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Данные вводятся с консоли пользователем

int[] array = new int[8];

int readInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < array.Length; i++)
{
    array[i] = readInt($"Введите {i + 1} элемент массива: ");
}

Console.WriteLine(string.Join(", ", array));