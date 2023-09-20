/* Задача 65: 
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers1(int start, int end)
{
    if (start == end) return $"{end}";
    return $"{start} {PrintNumbers1(start + 1, end)}";
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + " " + PrintNumbers(++start, end);
}


int numM = InputNum("Введи число M: ");
int numN = InputNum("Введи число N: ");
//Console.WriteLine(PrintNumbers1(numM, numN));
string series = PrintNumbers(numM, numN);
Console.WriteLine(series);

