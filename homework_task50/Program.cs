// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

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

int y = inputNumberPrompt("Введите номер строки Y: ");
int x = inputNumberPrompt("Введите номер столбца X: ");

System.Console.WriteLine(FindElement(MyArray, x, y));

// ----------------- Find element in array
string FindElement(double[,] arr, int x, int y)
{
	System.Console.WriteLine(arr.GetLength(0));
	System.Console.WriteLine(arr.GetLength(1));
	if (y > arr.GetLength(0) || x > arr.GetLength(1))
	{
		return "Координаты элемента за пределами массива.";
	}
	return arr[y - 1, x - 1].ToString();
}


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