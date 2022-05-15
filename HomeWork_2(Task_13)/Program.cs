// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int num1 = Math.Abs(num);

string text = num1.ToString();

Console.WriteLine("Оставляем третью цифру из числа: " + num + " -> " + text[2]);