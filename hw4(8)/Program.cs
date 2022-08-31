// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 1)
{
    Console.WriteLine("Число не положительное");
}
else
{
int NumberA = 1;
while (NumberA <= Number) ;
int ost = NumberA % 2;
if (ost == 0)
{
    Console.WriteLine(NumberA);
    NumberA = NumberA + 1;
}
}