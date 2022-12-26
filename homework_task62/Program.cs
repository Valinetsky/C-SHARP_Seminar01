// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


System.Console.WriteLine("Введите размерность массива");
int square = inputNumberPrompt("Введите размерность квадратного массива");
square = limitMinimum(1, square);



int[,] MyArray = new int[square, square];

int directFill = 0;
int counter = 1;

for (int i = 0; i < square; i++)
{
	MyArray[0, i] = counter;
	counter++;
}
printArray(MyArray);


while (counter <= square * square)
{
	int localCount = 1;

	int[] localDirection = ChangeDirection(directFill);
	System.Console.WriteLine(localDirection[0]);
	System.Console.WriteLine(localDirection[1]);

	int localX = square - 1;
	int localY = 0;

	for (int i = square - localCount; i >= 0; i--)
	{
		for (int j = 1; j <= i; j++)
		{
			localX = localX + localDirection[1];
			localY = localY + localDirection[0];
			System.Console.WriteLine("localX");
			System.Console.WriteLine(localX);
			System.Console.WriteLine("localY");
			System.Console.WriteLine(localY);

			MyArray[localY, localX] = counter;
			printArray(MyArray);
			System.Console.WriteLine("...");
			counter++;
		}

		directFill = (directFill + 1) % 4;
		localDirection = ChangeDirection(directFill);

		System.Console.WriteLine("directFill");
		System.Console.WriteLine(directFill);
		localCount++;
	}

}

printArray(MyArray);

for (int i = 0; i < 7; i++)
{
	System.Console.WriteLine("Change");
	System.Console.WriteLine(i);

	Console.WriteLine("Массив: [ " + string.Join(" | ", ChangeDirection(i % 4)) + " ]");

}






// System.Console.WriteLine(MyArray[3, 3]);

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

// --------------- direction
int[] ChangeDirection(int directFill)
{
	int[] arr = new int[2];

	if (directFill == 0)
	{
		arr[0] = 1;
	}

	if (directFill == 1)
	{
		arr[1] = -1;
	}

	if (directFill == 2)
	{
		arr[0] = -1;
	}

	if (directFill == 3)
	{
		arr[1] = 1;
	}
	return arr;
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