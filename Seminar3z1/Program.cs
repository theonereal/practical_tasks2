﻿/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int leng = number.Length;

if (leng == 5)
{
    if (number[0] == number [4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Ошибка: {number} - число не пятизначное");
}