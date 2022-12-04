// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100); // из отрезка [10, 99]
int num1 = number / 10;
int num2 = number - (number / 10) * 10; // number % 10
Console.WriteLine("Random number");
Console.WriteLine(number);

if (num1 > num2)
{
	Console.WriteLine(num1);
}

if (num2 >= num1)
{
	Console.WriteLine(num2);
}