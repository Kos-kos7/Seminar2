//принимает 2 числа и выводит, является ли второе кратное первому
int number1 = new Random().Next(100,1000);
int number2 = new Random().Next(1,10);
Console.WriteLine(number1);
Console.WriteLine(number2);

if (number1 % number2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");
