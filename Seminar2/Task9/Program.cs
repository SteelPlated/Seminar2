// Случайное число

//int number = new Random().Next(10, 100);
//Console.WriteLine($"number={number}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//Console.WriteLine($"number 1={firstDigit}");
//Console.WriteLine($"number 2={secondDigit}");

// первый метод
//if (firstDigit==secondDigit) 
//Console.WriteLine($"Max= {firstDigit}");
//else
//Console.WriteLine($"Max= {secondDigit}");

//второй метод
// Console.WriteLine(firstDigit > secondDigit ? $"Max= {firstDigit}" : $"Max = {secondDigit}");

//третий метод
int number = new Random().Next(10, 100);
Console.WriteLine($"number={number}");
int maxNum = FindMaxNumber(number);
Console.WriteLine($"Max={maxNum}");

int FindMaxNumber(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
return firstDigit / 10 > secondDigit % 10 ? firstDigit : secondDigit;
}