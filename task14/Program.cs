// Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число 
// квадратом другого.
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
	System.Console.WriteLine("Yeah!!!");
}
else
{
	System.Console.WriteLine("Not!");
}