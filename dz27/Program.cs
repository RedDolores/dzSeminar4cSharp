// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int extraNum = Num;
int tmp = 0;
int newNum = 0;

int getSum(int Num)
{
    while (extraNum > 0)
    {
        tmp = extraNum % 10;
        newNum = newNum + tmp;
        extraNum = extraNum / 10;
    }
    return newNum;

}

Console.WriteLine($"Сумма цифр в числе {Num} равна: {getSum(Num)}");