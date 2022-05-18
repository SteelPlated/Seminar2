// Напишите программу, которая принимает на вход два числа и проверяет
// является ли одно число квадратом другого.


Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B :");
int b = int.Parse(Console.ReadLine());

if(a * a == b)
Console.WriteLine("Да является!");
else
Console.WriteLine("Нет");