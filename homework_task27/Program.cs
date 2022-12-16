// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Привет! Будем искать сумму цифр введенного числа.");
System.Console.WriteLine("Для отрицательных чисел — отбрасываем знак.");

int A = inputNumber();

A = Math.Abs(A);

System.Console.WriteLine($"Сумма цифр числа {A} равна {diggitsSum(A)}");

// ----------------------------------------
int diggitsSum(int A)
{
    int sum = 0;

    while (A > 0)
    {
        sum = sum + A % 10;
        A = A / 10;
    }

    return sum;
}

// ----------------------------------------
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