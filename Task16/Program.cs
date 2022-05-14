//принимает 2 числа и выводит, является ли одно квадратом другого
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2 || number2*number2 == number1) Console.WriteLine("Yes");
else Console.WriteLine("No");
