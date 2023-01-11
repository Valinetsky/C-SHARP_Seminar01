// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


uint m = inputNumberPrompt("Введите первое число: ");
m = limitMinimum(0, m);
uint n = inputNumberPrompt("Введите второе число: ");
n = limitMinimum(0, n);

System.Console.WriteLine(AckermannFunction(m, n));

// --------------- Ackermann function
uint AckermannFunction(uint m, uint n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else
	{
		if (n == 0)
		{
			return AckermannFunction(m - 1, 1);
		}
	}
	return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

// --------------- limitation
uint limitMinimum(uint min, uint current)
{
	if (current < min)
	{
		System.Console.WriteLine("Предполагается число >= 0, значение скорректировано");
		current = min;
	}
	return current;
}

// ------------------------ safe input int number
uint inputNumberPrompt(string str)
{
	uint number;
	string text;

	while (true)
	{
		Console.Write($"{str} ");
		text = Console.ReadLine();
		if (uint.TryParse(text, out number))
		{
			break;
		}
		Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
	}
	return number;
}