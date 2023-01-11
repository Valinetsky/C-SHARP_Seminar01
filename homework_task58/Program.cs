// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// В коде закомментированы две строки:
// int[,] MatrixOne = { { 5, 0, 2, 3 }, { 4, 1, 5, 3 }, { 3, 1, -1, 2 } };
// int[,] MatrixTwo = { { 6 }, { -2 }, { 7 }, { 4 } };
// Результатом их перемножения будет { { 56 }, { 69 }, { 17 } };

// левая и правая границы диапазона чисел в массиве
int LEFTRANGE = -5;
int RIGHTRANGE = 5;

System.Console.WriteLine("Введите размерность массива");
int MatrixOneRow = inputNumberPrompt("Количество строк первой матрицы: ");
MatrixOneRow = limitMinimum(1, MatrixOneRow);

int MatrixOneCol = inputNumberPrompt("Количество столбцов первой матрицы: ");
MatrixOneCol = limitMinimum(1, MatrixOneCol);

int[,] MatrixOne = new int[MatrixOneRow, MatrixOneCol];
// int[,] MatrixOne = { { 5, 0, 2, 3 }, { 4, 1, 5, 3 }, { 3, 1, -1, 2 } };

arrayFill(MatrixOne, LEFTRANGE, RIGHTRANGE);

printArray(MatrixOne);

System.Console.WriteLine("************************");

int MatrixTwoRow = inputNumberPrompt("Количество строк второй матрицы: ");
MatrixTwoRow = limitMinimum(1, MatrixTwoRow);
if (MatrixTwoRow != MatrixOneCol)
{
	System.Console.WriteLine("Матрицу можно умножить на матрицу только в том случае, если число столбцов первой равняется числу строк второй. Размер скорректирован.");
	MatrixTwoRow = MatrixOneCol;
}

int MatrixTwoCol = inputNumberPrompt("Количество столбцов второй матрицы: ");
MatrixTwoCol = limitMinimum(1, MatrixTwoCol);

int[,] MatrixTwo = new int[MatrixTwoRow, MatrixTwoCol];
// int[,] MatrixTwo = { { 6 }, { -2 }, { 7 }, { 4 } };

arrayFill(MatrixTwo, LEFTRANGE, RIGHTRANGE);

printArray(MatrixTwo);

System.Console.WriteLine("========================");

int[,] MatrixMult = new int[MatrixOneRow, MatrixTwoCol];

getMatrixMult(MatrixOne, MatrixTwo, MatrixMult);

printArray(MatrixMult);

// --------------- Matrix Multiply
void getMatrixMult(int[,] FirstMatrix, int[,] SecondMatrix, int[,] result)
{
	for (int i = 0; i < FirstMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < SecondMatrix.GetLength(1); j++)
		{
			for (int k = 0; k < SecondMatrix.GetLength(0); k++)
			{
				result[i, j] = result[i, j] + FirstMatrix[i, k] * SecondMatrix[k, j];
			}
		}
	}
}

// --------------- limitation
int limitMinimum(int min, int current)
{
	if (current < min)
	{
		System.Console.WriteLine("Предполагается массив минимум из одного элемента, значение скорректировано");
		current = min;
	}
	return current;
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