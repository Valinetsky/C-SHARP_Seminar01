// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// левая и правая границы диапазона чисел в массиве
int LEFTRANGE = 0;
int RIGHTRANGE = 9;

System.Console.WriteLine("Введите размерность массива");
int m = inputNumberPrompt("Количество строк M: ");
m = limitMinimum(2, m);

int n = inputNumberPrompt("Количество столбцов N: ");
n = limitMinimum(2, n);

int[,] MyArray = new int[m, n];

arrayFill(MyArray, LEFTRANGE, RIGHTRANGE);

printArray(MyArray);

System.Console.WriteLine("---------------------");

System.Console.WriteLine(findMinIn2dArray(MyArray));

// --------------- limitation
int limitMinimum(int min, int current)
{
    if (current < min)
    {
        System.Console.WriteLine("Предполагается прямоугольный массив, значение скорректировано");
        current = min;
    }
    return current;
}

// --------------- Find min row in 2dARRAY
int findMinIn2dArray(int[,] arr)
{
    int sumTmp = sumOneDimArray(getRow(arr, 0));
    int rowNumber = 0;

    System.Console.WriteLine("Сумма элементов в первой строке:");
    System.Console.WriteLine(sumTmp);
        
    for (int i = 1; i < arr.GetLength(0); i++)
	{
        System.Console.WriteLine("Сумма элементов в строке:");
        System.Console.WriteLine(sumOneDimArray(getRow(arr, i)));
        if (sumOneDimArray(getRow(arr, i)) < sumTmp)
        {
            sumTmp = sumOneDimArray(getRow(arr, i));
            rowNumber = i;
        }
    }
    System.Console.WriteLine("Наименьшая сумма элементов:");
    System.Console.WriteLine(sumTmp);
    System.Console.WriteLine("В строке (строки считаются от 0):");
    return rowNumber;
}

// ------------------- Get row from 2dARRAY
int[] getRow(int[,] arr, int row)
{
	int[] RowArray = new int[arr.GetLength(1)];

	for (int i = 0; i < RowArray.Length; i++)
	{
		RowArray[i] = arr[row, i];
	}
	return RowArray;
}

// ------------------- sum 1dARRAY
int sumOneDimArray(int[] arr)
{
	int temp = 0;

	for (int i = 0; i < arr.Length; i++)
	{
		temp = temp + arr[i];
	}
    return temp;
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