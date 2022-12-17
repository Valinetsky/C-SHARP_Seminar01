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


arrayFill(myArray, leftRange, rightRange);
// System.Console.WriteLine("88888888888888888888888888888888888");
// Console.WriteLine("Массив: [ " + string.Join(" | ", myArray) + " ]");

// System.Console.WriteLine($"Количество четных чисел в массиве: {sumInArray(myArray)}");

// -------------- SUM in array ------------
// int sumInArray(int[] arr)
// {
// 	int sum = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 2 == 0)
// 		{
// 			System.Console.WriteLine(arr[i]);
// 			sum++;
// 		}
// 	}
// 	return sum;
// }

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

// --------------------- RANDOM NUMBER from - to -------------------
double GetRandomFrom(int bottom, int top)
{
	Random rnd = new Random();
	// Random rndDouble = rnd.NextDouble();
	double result = rnd.Next(bottom, top) + rnd.NextDouble();
	// К целому случайному числу из диапазона добавляем случайное число
	// из математического диапазона [0, 1) - единица не входит.
	// Получим вещественное число не превышающее общий диапазон.
	// Как-то непросто, но пока - так.
	System.Console.WriteLine("=============================");
	System.Console.WriteLine(result);
	return result;
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