/* Задача 63: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int num, int start)
{
    if (start > num) return;
    Console.Write($"{start} ");
    PrintNumbers(num, start + 1);
}

void PrintNumbers2(int num)
{
    if (num == 0) return;
    PrintNumbers2(num - 1);
    Console.Write($"{num} ");
}

void PrintN(int numN)
{
    if (numN > 1)
    {
        PrintN(numN - 1);
        Console.Write($"{numN} ");
    }
    else Console.Write($"{numN} ");
}


int numN = InputNum("Введи число N: ");

//PrintN(numN);
//PrintNumbers(numN, 1);
PrintNumbers2(numN);