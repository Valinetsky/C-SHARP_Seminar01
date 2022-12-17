// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = inputNumberPrompt("Введите размер массива: ");

if (size < 0)
{
	System.Console.WriteLine("В качестве размера будет использовано абсолютное значение введенного числа");
	size = Math.Abs(size);
}

double[] myArray = new double[size];

int leftRange;
int rightRange;

leftRange = inputNumberPrompt("Введите левую границу чисел в массиве: ");

rightRange = inputNumberPrompt("Введите правую границу чисел в массиве: ");

int leftRangeNormalize = numberMin(leftRange, rightRange);

int rightRangeNormalize = numberMax(leftRange, rightRange);

leftRange = leftRangeNormalize;
rightRange = rightRangeNormalize;

System.Console.WriteLine("leftRange");
System.Console.WriteLine(leftRange);
System.Console.WriteLine("rightRange");
System.Console.WriteLine(rightRange);

arrayFill(myArray,
		  leftRange,
		  rightRange);

// ============== Main OUTPUT
System.Console.WriteLine("Значение минимального элемента массива:");
System.Console.WriteLine(findMinInArray(myArray));
System.Console.WriteLine("+++++++++++++");
System.Console.WriteLine("Значение максимального элемента массива:");
System.Console.WriteLine(findMaxInArray(myArray));
System.Console.WriteLine("===");
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива:");
System.Console.WriteLine(getDiffirence(findMinInArray(myArray), findMaxInArray(myArray)));

// ------------- function return diff between miт and max
double getDiffirence(double min, double max)
{
	double result = max - min;
	return result;
}

// ------------Two function to find MIN and MAX in array
double findMinInArray(double[] arr)
{
	double localMin = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] < localMin)
		{
			localMin = arr[i];
		}
	}
	return localMin;
}

double findMaxInArray(double[] arr)
{
	double localMax = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > localMax)
		{
			localMax = arr[i];
		}
	}
	return localMax;
}

// ------------Function to find first index of number in array
// ------- not used in task -------------
double findIndexOfInArray(double[] arr, double number)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] == number)
		{
			return number;
		}
	}
	return -1;
}

// ------------------- fill ARRAY
double[] arrayFill(double[] arr, int left, int right)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = GetRandomFrom(left, right);
	}
	System.Console.WriteLine("=====================");
	Console.WriteLine("Массив: [ " + string.Join(" | ", arr) + " ]");

	return arr;
}

// ------------Two function to normalize left and right range
int numberMin(int leftRange, int rightRange)
{
	return Math.Min(leftRange, rightRange);
}

int numberMax(int leftRange, int rightRange)
{
	return Math.Max(leftRange, rightRange);
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