// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
Console.WriteLine("Hello, World!");

// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num2 = number % 10;
int result = num1 * 10 + num2;
Console.WriteLine("Random number");
Console.WriteLine(number);

Console.WriteLine(result);

string numToStr = Convert.ToString(number);
Console.WriteLine("number to string");
Console.WriteLine(numToStr);
Console.Write(numToStr[0]);
Console.WriteLine(numToStr[2]);

Console.WriteLine($"{numToStr[0]}{numToStr[2]}");
