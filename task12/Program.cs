// Напишите программу, которая на вход будет принимать два числа и выводить, является ли второе число кратным первому
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num2 % num1;

if (remainder == 0)
{
	Console.WriteLine("Число {0:D} кратно числу {1:D}", num2, num1);
}

if (remainder != 0)
{
	Console.WriteLine("Число {0:D} не кратно числу {1:D}. Остаток {2:D}", num2, num1, remainder);
}