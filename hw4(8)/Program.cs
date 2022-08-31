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
int NumberA = 0;// NumberA - переменная , которая будет меняться от 0 до "N" 
while (NumberA < Number) ;
int ost = NumberA % 2; // ost - остаток после деления на 2 , для определения положительного числа
if (ost == 0)
{
    Console.WriteLine(NumberA);
    NumberA = NumberA + 1;
}
