// // Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int NumberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int NumberC = Convert.ToInt32(Console.ReadLine());

int Max = 0;

if(NumberA > NumberB)
{
    Max = NumberA;
}
else
{
    Max = NumberB;
}
if(Max < NumberC)
{
    Max = NumberC;
}
Console.WriteLine("Максимальное число = ");
Console.WriteLine(Max);