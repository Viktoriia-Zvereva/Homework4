int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double PowResult(double a, int b)
{
    double result = 1;
    while (b!=0)
    {
    result = result * a;
    b -= 1;
    }
    return result;
}

void Task25()
{
    //Используя определение степени числа, напишите цикл, 
    //который принимает на вход два натуральных числа (A и B)
    //и возводит число A в степень B.
    Console.WriteLine("Задача 25");

    int a = Input("Введите число A: ");
    int b = Input("Введите число B: ");
    double result = PowResult(a, b);
    if (b < 1)
    {
        Console.WriteLine($"Ошибка ввода. Число B должно быть натуральным.");
    }
    else
    {
        Console.Write($"Число A в натуральной степени B равно {result}");
    }
}

void Task27()
{
    //Напишите программу, которая принимает на вход число 
    //и выдаёт сумму цифр в числе.
    Console.WriteLine("Задача 27");

    int number = Input("Введите число: ");
    int sum = 0;
    int currentValue = number;

    while (currentValue > 0)
    {
        sum = currentValue % 10 + sum;
        currentValue = currentValue / 10;
    }
    Console.WriteLine($"Сумма чисел в числе {number} равна {sum}");
}

void FillArray(int[] array, int minValue = -10, int maxValue = 10)
{
    maxValue ++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Task29()
{
    // Напишите программу, которая задаёт массив из 8 случайных целых чисел 
    //и выводит отсортированный по модулю массив.
    Console.WriteLine("Задача 29");

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);

    for (int i = 0;i < numbers.Length; i++)
    {
        for (int j = 0;j < numbers.Length - i - 1; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    PrintArray(numbers);  
}

Console.Clear();
Console.WriteLine("25 - Задача 25\n27 - Задача 27\n29 - Задача 29");
int TaskNumber = Input("Введите номер задачи: ");

switch(TaskNumber)
{
    case 25:
        Task25();
        break;
    case 27:
        Task27();
        break;
    case 29:
        Task29();
        break;
    default:
        Console.WriteLine("Введен неверный номер задачи");
        break;
}