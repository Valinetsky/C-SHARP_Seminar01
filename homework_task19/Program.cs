int digitFromNumber(int number, int position)
// Функция возвращает цифру из числа, в указанной позиции
{
    int localDigit = number / Convert.ToInt32(Math.Pow(10, position)) % 10;
    return localDigit;
}

int flag = -1;
int number;
string text;

while (true)
{
    Console.Write("Введите число: ");
    text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        Console.WriteLine("Вы ввели число {0}", number);
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

if (text.Length != 5)
{
    System.Console.WriteLine("Число должно содержать пять знаков");
    System.Console.WriteLine("Но мы не привыкли отступать: ищем палиндромы в числах примерно до int32");
}

if (number < 0) flag = 0;

if (number == 0) flag = 1;

if (number > 0)
{
    int digits = 1 + Convert.ToInt32(Math.Truncate(Math.Log10(number)));
    Console.WriteLine("digits");
    Console.WriteLine(digits);
    int halfSize = digits / 2;

    flag = 1;

    if (digits > 1)
    {
        for (int i = 0; i < halfSize; i++)
        {   
            int top = digitFromNumber(number, i);
            int bottom = digitFromNumber(number, digits - i - 1);

            Console.WriteLine(top);
            Console.WriteLine(bottom);
            System.Console.WriteLine("--------------");

            if (top != bottom)
            {
                flag = 0;
                break;
            }  
        }
    }
}

if (flag == 1)
{
    System.Console.WriteLine($"Number {number} is palindrome");
}

if (flag == 0)
{
    System.Console.WriteLine("No palindrome here");
}