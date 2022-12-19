// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int LEFT_RANGE = -999;
int RIGHT_RANGE = 999;

int arrSize = inputNumberPrompt("Введите размер массива для генерации набора чисел: ");

int[] MyArr = new int[arrSize];

arrayFill(MyArr, LEFT_RANGE, RIGHT_RANGE);

System.Console.WriteLine($"Чисел больше 0 в массиве: {countOverZero(MyArr)}");

// ---------- count numbers > 0 ----
int countOverZero(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > 0)
		{
			count++;
		}
	}
	return count;
}

// ------------------- fill ARRAY
void arrayFill(int[] arr, int left, int right)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = GetRandomFrom(left, right);
	}
	System.Console.WriteLine("=====================");
	Console.WriteLine("Массив: [ " + string.Join(" | ", arr) + " ]");
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