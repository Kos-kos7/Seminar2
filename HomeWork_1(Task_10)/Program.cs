﻿//  Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Генерирую случайное трехзначное число");
int num = new Random().Next(100,1000);
Console.WriteLine("Число = " + num);

int num1 = Math.Abs(num);

string text = num1.ToString();

Console.WriteLine("Оставляем вторую цифру из трехзначного числа: " + num + " -> " + text[1]);