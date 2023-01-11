// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


int m = inputNumberPrompt("Введите левую границу диапазона: ");
int n = inputNumberPrompt("Введите правую границу диапазона: ");

if (m > n)
{
	System.Console.WriteLine("Нормализация границ диапазона");
	int temp = m;
	m = n;
	n = temp;
}

System.Console.WriteLine("--------------");
System.Console.WriteLine(recursiveSum(m, n));


// ------------ recursive SUM
int recursiveSum(int left, int right)
{
	if (left == right)
	{
		return right;
	}

	return right + recursiveSum(left, right - 1);
}


// ------------------------ safe input int number
int inputNumberPrompt(string str)
{
	int number;
	string text;

	while (true)
	{
		Console.Write($"{str} ");
		text = Console.ReadLine();
		if (int.TryParse(text, out number))
		{
			break;
		}
		Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
	}
	return number;
}