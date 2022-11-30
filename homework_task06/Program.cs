Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
	Console.Write("Yeah! " + number + " is even (чет).");
}

if ((number % 2) == 1)
{
	Console.Write("No! " + number + " is odd (нечет).");
}