using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Выберите операцию (+, -, *, /):");
        string operation = Console.ReadLine();
        double result = 0;
        bool validOperation = true;
        switch (operation)
        {
            case "+":
                result = Add(firstNumber, secondNumber);
                break;
            case "-":
                result = Subtract(firstNumber, secondNumber);
                break;
            case "*":
                result = Multiply(firstNumber, secondNumber);
                break;
            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    validOperation = false;
                }
                else
                {
                    result = Divide(firstNumber, secondNumber);
                }
                break;
            default:
                Console.WriteLine("Ошибка: неверная операция.");
                validOperation = false;
                break;
        }
        if (validOperation)
        {
            Console.WriteLine($"Результат: {result}");
        }
        AnalyzeNumber(firstNumber, "первое");
        AnalyzeNumber(secondNumber, "второе");
    }
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
    static void AnalyzeNumber(double number, string numberOrder)
    {
        string parity = (number % 2 == 0) ? "четное" : "нечетное";
        string sign = (number > 0) ? "положительное" : (number < 0) ? "отрицательное" : "ноль";
        Console.WriteLine($"Анализ {numberOrder} числа:");
        Console.WriteLine($"{number} - {parity}, {sign}");
    }
}
