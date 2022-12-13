// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Делаем массив вашего размера, из чисел вашего диапазона");
System.Console.WriteLine("Размер массива");

int size = inputNumber();
if (size < 0)
{
    System.Console.WriteLine("В качестве размера будет использовано абсолютное значение введенного числа");
    size = Math.Abs(size);
}

int [] array = new int[size];

System.Console.WriteLine("---------------------");
System.Console.WriteLine("Нижняя граница диапазона чисел в массиве");
int bottom = inputNumber();

System.Console.WriteLine("---------------------");
System.Console.WriteLine("Верхняя граница диапазона чисел в массиве");
int top = inputNumber();

System.Console.WriteLine("Границы диапазона будут нормализованы: нижняя - минимум, верхняя - максимум.");

if (bottom > top)
{
    int exchange = bottom;
    bottom = top;
    top = exchange;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetRandomFrom(bottom, top);
}

System.Console.WriteLine("=====================");
Console.WriteLine("Массив: [ " + string.Join(" | ", array) + " ]");

// ----------------------------------------
int GetRandomFrom(int bottom, int top)
{
    Random rnd = new Random();
    int result = rnd.Next(bottom, top + 1);
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