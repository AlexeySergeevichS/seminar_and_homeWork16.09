/* Задача 67: 
Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumOfNumbers(int num)
{
    if (num == 0) return 0;
    return SumOfNumbers(num / 10) + num % 10;
}

int num = InputNum("Введи число: ");
int res = SumOfNumbers(num);
Console.WriteLine(res);