﻿// // Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());

int ost = NumberA % 2;
if(ost == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}