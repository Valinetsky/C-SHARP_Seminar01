// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// левая и правая границы диапазона чисел в массиве
int LEFTRANGE = -10;
int RIGHTRANGE = 10;

System.Console.WriteLine("Введите размерность массива");
int m = inputNumberPrompt("Количество строк M: ");
int n = inputNumberPrompt("Количество столбцов N: ");

double w = inputNumberPromptDouble("Probe");

int[,] MyArray = new int[m, n];

arrayFill(MyArray, LEFTRANGE, RIGHTRANGE);

printArray(MyArray);

EveryMiddleColumn(MyArray);


// ------------------- цикл по средним столбцов
void EveryMiddleColumn(int[,] arr)
{
	for (int i = 1; i <= arr.GetLength(1); i++)
	{
		System.Console.Write($"Среднее арифмтическое столбца {i} равно: ");
		System.Console.WriteLine(MiddleColumn(MyArray, i));
	}
}

// ------------------- средее арифметическое столбца
double MiddleColumn(int[,] arr, int column)
{
	double sum = 0;
	int j = 0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		sum = sum + arr[i, column - 1];
		j++;
	}
	return sum / j;
}

// ------------------- PRINT 2dARRAY
void printArray(int[,] arr)
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

// ------------------- fill ARRAY int numbers
void arrayFill(int[,] arr, int left, int right)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = GetRandomFrom(left, right);
		}
	}
}

// --------------------- RANDOM NUMBER from - to -------------------
int GetRandomFrom(int bottom, int top)
{
	Random rnd = new Random();
	int result = rnd.Next(bottom, top + 1);
	return result;
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

// ------------------------ safe input double number
double inputNumberPromptDouble(string str)
{
	System.Console.WriteLine("При вводе десятичного разделителя");
	System.Console.WriteLine("в зависимости от настроек региона");
	System.Console.WriteLine("нужно набрать \",\" или \".\".");
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