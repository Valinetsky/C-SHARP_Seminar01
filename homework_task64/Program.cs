// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int M = inputNumberPrompt("Введите число");
M = limitMinimum(1, M);

countDown(M);

// -------------- recursive countdown
void countDown(int number)
{
	if (number == 0)
	{
		return;
	}
	System.Console.WriteLine(number);
	countDown(number - 1);
}

// --------------- limitation
int limitMinimum(int min, int current)
{
	if (current < min)
	{
		System.Console.WriteLine("Предполагается минимальное значение - 1, значение скорректировано");
		current = min;
	}
	return current;
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