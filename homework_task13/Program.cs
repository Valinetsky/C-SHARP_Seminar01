// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645-> 5

// 78->третьей цифры нет

// 32679 -> 6
Console.Write("Input number: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);

// From string
if (strNumber.Length <= 2)
{
	Console.WriteLine("No third digit");
}
else
{
	Console.WriteLine($"From string. Third digit: {strNumber[2]}");
}

// From number
if (number < 100)
{
	Console.WriteLine("No third digit");
}
else
{
	int digits = 1 + Convert.ToInt32(Math.Truncate(Math.Log10(number)));
	int result = number / Convert.ToInt32(Math.Pow(10, digits - 3)) % 10;
	Console.WriteLine($"From number. Third digit: {result}");
}

