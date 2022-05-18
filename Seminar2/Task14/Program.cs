// Напишите программу, котрая принимает на вход число
// и проверяет,  кратно ли оно одноверменно 7 и 23.

Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0) Console.WriteLine($"да");
else Console.WriteLine($"нет");