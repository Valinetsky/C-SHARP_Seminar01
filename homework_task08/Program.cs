Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2)
{
	Console.Write("Number is less than 2");
}

if (number >= 2)
{
	for (int index = 2; index <= number; index++)
	{
		if ((index % 2) == 0)
		{
			Console.WriteLine(index);
		}

	}
}