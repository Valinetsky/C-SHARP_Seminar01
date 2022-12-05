// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели (1-7): ");
string? input = Console.ReadLine();

bool result = int.TryParse(input, out var number);
if (result == true)
{
	// Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
	if (number >= 1 && number <= 7)
	{
		if (number >= 6)
		{
			Console.WriteLine("Да. Это — выходной.");
		}
		else
		{
			Console.WriteLine("Нет. Это — рабочий день.");
		}
	}
	else
	{
		Console.WriteLine("Введенное число вне диапазона 1-7.");
	}
}

else
	Console.WriteLine("Преобразование строки в число завершилось неудачно");