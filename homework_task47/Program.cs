// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// левая и правая границы диапазона вещественных чисел в массиве
int LEFTRANGE = -10;
int RIGHTRANGE = 10;
// количество знаков после запятой
int DIGITS = 3;

System.Console.WriteLine("Введите размерность массива");
int m = inputNumberPrompt("Количество строк M: ");
int n = inputNumberPrompt("Количество столбцов N: ");

double[,] MyArray = new double[m, n];

arrayFill(MyArray, LEFTRANGE, RIGHTRANGE, DIGITS);

printArray(MyArray);


// ------------------- PRINT 2dARRAY
void printArray(double[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		System.Console.Write("[ ");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			System.Console.Write("\t " + arr[i, j]);
		}
		System.Console.Write("\t]");
		System.Console.WriteLine();
	}
}

// ------------------- fill ARRAY
void arrayFill(double[,] arr, int left, int right, int digits)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = Math.Round(GetRandomFrom(left, right), digits);
		}
	}
}

// --------------------- RANDOM NUMBER from - to (not included) -------------------
double GetRandomFrom(int bottom, int top)
{
	Random rnd = new Random();
	return bottom + rnd.NextDouble() * (top - bottom);
}

// ------------------------ safe input number
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