System.Console.WriteLine("Программа возведения числа А в степень В, используя цикл.");

System.Console.WriteLine("Число А");
int A = inputNumber();

System.Console.WriteLine("Степень В");
int B = inputNumber();

System.Console.WriteLine($"{A} в степени {B} равно {localPow(A, B)}");

// ----------------------------------------
int localPow(int arg, int power)
{
	int result = 1;

	for (int i = 1; i <= power; i++)
	{
		result = result * arg;
	}
	return result;
}
// ----------------------------------------
int inputNumber()
{
	int number;
	string text;

	while (true)
	{
		Console.Write("Введите число: ");
		text = Console.ReadLine();
		if (int.TryParse(text, out number))
		{
			break;
		}
		Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
	}
	return number;
}