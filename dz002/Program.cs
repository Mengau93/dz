// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 4;
int b = -6;
int c = -12;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write ("max = ");
Console.WriteLine(max);
