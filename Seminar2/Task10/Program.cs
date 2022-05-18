// Напишите программу,  которая выводит случайное 3х значное число и удаляет вторую цифру.

int number = new Random(). Next(100, 999);
Console.WriteLine($"number={number}");

int first = number/100;
int last = number%10;
int res = first * 10 + last;
Console.WriteLine($"Результат = {res}");
