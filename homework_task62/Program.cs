// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int square = inputNumberPrompt("Введите размерность квадратного массива");
square = limitMinimum(1, square);

int[,] MyArray = new int[square, square];

spiralFilling(MyArray);

System.Console.WriteLine();
System.Console.WriteLine("Final output");
printArray(MyArray);

// ------------------ 2d square Array spiral filling
void spiralFilling(int[,] arr)
{
	// Направление заполнения массива: 0 - влево, 1 - вниз, 2 - вправо, 3 - вверх
	int directFill = 0; 
	
	int counter = 1;
	int[] localDirection = new int[2];

	int localX = 0;
	int localY = 0;

	arr[localX, localY] = counter;
	counter++;

	while (counter <= arr.GetLength(0) * arr.GetLength(0))
	{
		// Получаем массив приращения направлений. Для каждой из двух координат.
		localDirection = ChangeDirection(directFill);
		
		int newLocalX = localX + localDirection[0];
		int newLocalY = localY + localDirection[1];

		if (newLocalX < 0 || newLocalX >= square || newLocalY < 0 || newLocalY >= square)
		{
			directFill = (directFill + 1) % 4;
			continue;
		}

		if (arr[newLocalY, newLocalX] != 0)
		{
			directFill = (directFill + 1) % 4;
			continue;
		}
		arr[newLocalY, newLocalX] = counter;

		// // ------------ Array fill step output
		// System.Console.WriteLine();
		// printArray(arr);
		
		counter++;
		localX = newLocalX;
		localY = newLocalY;
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