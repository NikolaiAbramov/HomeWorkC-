﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример1: 4 -> да
// Пример1: -3 -> нет
// Пример1: 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine("да");
else
Console.WriteLine("нет");