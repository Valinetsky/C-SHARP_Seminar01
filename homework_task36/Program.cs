// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int size = inputNumberPrompt("Введите размер массива: ");

if (size < 0)
{
	System.Console.WriteLine("В качестве размера будет использовано абсолютное значение введенного числа");
	size = Math.Abs(size);
}

int[] myArray = new int[size];

int leftRange;
int rightRange;

leftRange = inputNumberPrompt("Введите левую границу чисел в массиве: ");

rightRange = inputNumberPrompt("Введите правую границу чисел в массиве: ");

if (leftRange > rightRange)
{
	int exchange = leftRange;
	leftRange = rightRange;
	rightRange = exchange;
}

// System.Console.WriteLine("Левая граница = 100, правая = 999");

// leftRange = 100;
// rightRange = 999;

arrayFill(myArray, leftRange, rightRange);
// System.Console.WriteLine("88888888888888888888888888888888888");
// Console.WriteLine("Массив: [ " + string.Join(" | ", myArray) + " ]");

System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumInOddPosition(myArray)}");

// -------------- SUM in array ------------
int sumInOddPosition(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (i % 2 == 1)
		{
			System.Console.Write(arr[i] + " по индексу ");
			System.Console.WriteLine(i);
			sum = sum + arr[i];
			System.Console.Write("Текущая сумма: ");
			System.Console.WriteLine(sum);
		}
	}
	return sum;
}

// ------------------- fill ARRAY
int[] arrayFill(int[] arr, int left, int right)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = GetRandomFrom(left, right);
	}
	System.Console.WriteLine("=====================");
	Console.WriteLine("Массив: [ " + string.Join(" | ", arr) + " ]");

	return arr;
}

// --------------------- RANDOM NUMBER from - to -------------------
int GetRandomFrom(int bottom, int top)
{
	Random rnd = new Random();
	int result = rnd.Next(bottom, top + 1);
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