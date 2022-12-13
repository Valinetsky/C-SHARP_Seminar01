// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Привет! Будем возводить число А в степень Б.");
System.Console.WriteLine("Сначала — А");
int A = inputNumber();
System.Console.WriteLine("Теперь — Б");
int B = inputNumber();

System.Console.WriteLine($"Число {A} в степени {B} равно {numberPow(A, B)}");

// ----------------------------------------
int numberPow(int A, int B)
{
    int result = 1;

    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }

    return result;
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