//Программа которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
int NumberA = Number / 10;
int NumberTwo = NumberA % 10;
Console.WriteLine( "" + Number + "->" + NumberTwo);
