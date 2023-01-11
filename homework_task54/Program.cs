// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// левая и правая границы диапазона чисел в массиве
int LEFTRANGE = 1;
int RIGHTRANGE = 9;

System.Console.WriteLine("Введите размерность массива");
int m = inputNumberPrompt("Количество строк M: ");
int n = inputNumberPrompt("Количество столбцов N: ");

int[,] MyArray = new int[m, n];

arrayFill(MyArray, LEFTRANGE, RIGHTRANGE);

printArray(MyArray);

System.Console.WriteLine("---------------------");

sortTwoDimArray(MyArray);

printArray(MyArray);

// --------------- Sort rows in 2dARRAY
void sortTwoDimArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		int[] MyArrayToSort = getRow(arr, i);

		sortOneDimArray(MyArrayToSort);

		putRow(arr, MyArrayToSort, i);
	}
}

// ------------------- Put row in 2dARRAY
void putRow(int[,] arr, int[] RowArray, int row)
{
	for (int i = 0; i < RowArray.Length; i++)
	{
		arr[row, i] = RowArray[i];
		// System.Console.Write(RowArray[i]);
		// System.Console.Write(" ");
	}
	// System.Console.WriteLine();
}

// ------------------- Get row from 2dARRAY
int[] getRow(int[,] arr, int row)
{
	int[] RowArray = new int[arr.GetLength(1)];

	for (int i = 0; i < RowArray.Length; i++)
	{
		RowArray[i] = arr[row, i];
		// System.Console.Write(RowArray[i]);
		// System.Console.Write(" ");
	}
	// System.Console.WriteLine();
	return RowArray;
}

// ------------------- sort 1dARRAY
void sortOneDimArray(int[] arr)
{
	int temp;

	for (int i = 0; i < arr.Length - 1; i++)
	{
		for (int j = i + 1; j < arr.Length; j++)
		{
			if (arr[i] < arr[j])
			{
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
	
			}
		}
	}
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