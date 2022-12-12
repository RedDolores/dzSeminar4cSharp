// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!


int readInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = readInt("Введите число A: ");
int b = readInt("Введите число B: ");

int result = a;

for(int i = 1; i < b; i++)
{
    result *= a;
}

Console.WriteLine(result);