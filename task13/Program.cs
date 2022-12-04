// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
	System.Console.WriteLine("Кратно!");
}
else
{
	System.Console.WriteLine("Не кратно!");
}