// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine(("Введите число: "));
int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());


int Power(int num, int power)
{
    if (power == 1) return num;
    if (power == 0) return 1;
    return (num * Power(num, power - 1));
    
}
Console.WriteLine($"Число {number} в степени {degree} = {Power(number, degree)}");