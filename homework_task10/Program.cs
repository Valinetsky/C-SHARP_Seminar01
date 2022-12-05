// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Input number: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);

Console.WriteLine($"From string. Second digit: {strNumber[1]}");

int result = (number / 10) % 10;
Console.WriteLine($"From number. Second digit: {result}");