/* Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double PowRecursion(int num, int pow)
{
    if (pow == 0) return 1;
    if (pow > 0) return num * PowRecursion(num, --pow);
    else return 1.0 / num * PowRecursion(num, ++pow);
}

int num = InputNum("Введи число А: ");
int pow = InputNum("Введи степень В: ");
double res = PowRecursion(num, pow);
Console.WriteLine($"{res:f2}");
