Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
	Console.WriteLine("Yeah!");
	// Console.WriteLine(a, b);
}

if (a != b * b)
{
	Console.WriteLine("Not");
}