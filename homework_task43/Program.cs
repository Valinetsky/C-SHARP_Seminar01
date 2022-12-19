// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

System.Console.WriteLine("Ищем точку пересечения двух прямых");
System.Console.WriteLine("Уравнения прямых");
System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2;");
System.Console.WriteLine("При вводе десятичного разделителя");
System.Console.WriteLine("в зависимости от настроек региона");
System.Console.WriteLine("нужно набрать \",\" или \".\".");

double k1 = inputNumberPrompt("Введите k1");
System.Console.WriteLine("-----------------");

double b1 = inputNumberPrompt("Введите b1");
System.Console.WriteLine("-----------------");

double k2 = inputNumberPrompt("Введите k2");
System.Console.WriteLine("-----------------");

double b2 = inputNumberPrompt("Введите b2");
System.Console.WriteLine("-----------------");

double X = coordX(b1, b2, k1, k2);
double Y = coordY(b1, k1, X);

// Артём, приветствую в коде! По поводу неиспользования
// (else) и (else if) — считаю, что без них код более удобно читать.
// Поэтому стараюсь обходиться без них.
// Просто такая особенность написания кода. Как бы авторский стить. .)
if (k1 != k2)
{
	System.Console.WriteLine($"Точка пересечения прямых (X = {X}, Y = {Y})");
}

if (k1 == k2)
{
	System.Console.WriteLine("Прямые параллельны или совпадают.");
}

// -------------- coord X from to lines y = kx+b
double coordX(double b1, double b2, double k1, double k2)
{
	double X = (b2 - b1) / (k1 - k2);
	return X;
}

// -------------- coord X from to lines y = kx+b
double coordY(double b1, double k1, double X)
{
	double Y = k1 * X + b1;
	return Y;
}

// ------------------------ safe input double number
double inputNumberPrompt(string str)
{
	double number;
	string text;

	while (true)
	{
		Console.Write($"{str} ");
		text = Console.ReadLine();
		if (double.TryParse(text, out number))
		{
			break;
		}
		Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
	}
	return number;
}