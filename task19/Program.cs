﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int a1 = number / 10000;
int a2 = number / 1000 % 10;
int a4 = number / 10 % 10;
int a5 = number % 10;
if (a1 == a5 && a2 == a4)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}