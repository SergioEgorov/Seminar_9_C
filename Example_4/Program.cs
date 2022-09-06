// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine(("Введите число: "));
int number = Convert.ToInt32(Console.ReadLine());

int summ = 0;
int SumDigit(int number)
{
    if (number /10 == 0) return number;
    return number%10 + SumDigit(number/10);
    
}
Console.WriteLine(SumDigit(number));