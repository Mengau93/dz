//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 12;
int b = 10;

int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write ("max = ");
Console.WriteLine(max);

Console.Write ("min = ");
Console.WriteLine(min);
