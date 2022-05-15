//  Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
string numWeek = Console.ReadLine();

if(numWeek == "6") || (numWeek == "7") Console.WriteLine("Ура выходной");
else Console.WriteLine("Опять на работу");  

