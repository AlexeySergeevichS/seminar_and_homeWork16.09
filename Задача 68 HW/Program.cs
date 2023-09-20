/*  Задача 68: 
 Напишите программу вычисления функции Аккермана с помощью рекурсии.
  Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

uint InputNum(string message)
{
    Console.Write(message);
    return uint.Parse(Console.ReadLine()!);
}

uint AkkerMan(uint numM, uint numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return AkkerMan(numM - 1, 1);
    return AkkerMan(numM - 1, AkkerMan(numM, numN - 1));
}

uint numberM = InputNum("Введи число M: ");
uint numberN = InputNum("Введи число N: ");
uint res = AkkerMan(numberM, numberN);
Console.WriteLine(res);