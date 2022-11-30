int quantity = 3;

int[] array = new int[quantity];

for (int index = 1; index <= quantity; index++)
{
	Console.Write("Input " + index + " number: ");
	array[index - 1] = Convert.ToInt32(Console.ReadLine());
}

int max = array[0];

for (int index = 1; index < quantity; index++)
{
	if (max < array[index])
	{
		max = array[index];
	}
}

Console.WriteLine("Max number: " + max);