// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)


// левая и правая границы диапазона чисел в массиве
int LEFTRANGE = 10;
int RIGHTRANGE = 99;
int CUBE = 2;

int[,,] My3dArray = new int[CUBE, CUBE, CUBE];

Fill3dArray(My3dArray, LEFTRANGE, RIGHTRANGE);

print3dArray(My3dArray);


// --------------------- RANDOM NUMBER from - to -------------------
int GetRandomFrom(int bottom, int top)
{
	Random rnd = new Random();
	int result = rnd.Next(bottom, top + 1);
	return result;
}

// ---------------------- fill 3d Array
void Fill3dArray(int[,,] arr, int left, int right)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				arr[i, j, k] = GetRandomFrom(left, right);
			}
		}
	}
}

// ---------------------- print 3d Array
void print3dArray(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				// построчный вывод массива в соответствие с условием задачи
				Console.Write($"{arr[j, k, i]}: [{j},{k},{i}]; ");
			}
			Console.WriteLine();
		}
	}
}