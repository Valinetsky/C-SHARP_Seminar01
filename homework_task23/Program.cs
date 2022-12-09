int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

int cube = inputNumber();

System.Console.Write($"{cube} -> ");

for (int i = 1; i <= cube; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}