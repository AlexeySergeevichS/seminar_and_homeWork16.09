/* Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumOfNumbersFromMtoN(int m, int n)
{
    if (m != n)
    {
        return m + SumOfNumbersFromMtoN(m + 1, n);

    }
    return n;
}

int numberM = InputNum("Введи число M: ");
int numberN = InputNum("Введи число N: ");
int res = SumOfNumbersFromMtoN(numberM, numberN);
Console.WriteLine(res);