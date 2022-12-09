int[] array = new int[6];

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

Console.WriteLine("Ввод координат");
int counter = 0;
for (int j = 1; j <= 2; j++)
{
    for (int i = 1; i <= 3; i++)
    {
        string symbol = "X";
        if (i == 1) symbol = "X";
        if (i == 2) symbol = "Y";
        if (i == 3) symbol = "Z";
        System.Console.WriteLine($"Координата {symbol}{j}");
        array[counter] = inputNumber();
        counter++;
    }
}

double result = Math.Sqrt(
                Math.Pow(array[3] - array[0], 2) 
              + Math.Pow(array[4] - array[1], 2) 
              + Math.Pow(array[5] - array[2], 2)
                );

System.Console.WriteLine(result);

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
