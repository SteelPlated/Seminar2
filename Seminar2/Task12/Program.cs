// Напишите программу, которая будет принимать на вход два случайных числа и выводить является ли второое число кратным первому.
// Если второе не кратно, то программа выводит остаток от деления.

Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B :");
int b = int.Parse(Console.ReadLine());
if (a % b == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, Остаток - {a % b}");