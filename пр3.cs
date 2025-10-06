using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРАКТИЧЕСКАЯ РАБОТА №3");
            Console.WriteLine("КАЛЬКУЛЯТОР");
            Console.WriteLine("================================");

            bool continueCalculating = true;

            while (continueCalculating)
            {
                ShowMenu();
                Console.Write("Выберите операцию (1-9): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    case "5":
                        Power();
                        break;
                    case "6":
                        SquareRoot();
                        break;
                    case "7":
                        Modulo();
                        break;
                    case "8":
                        QuadraticEquation();
                        break;
                    case "0":
                        continueCalculating = false;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        break;
                }

                if (continueCalculating)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("МЕНЮ ОПЕРАЦИЙ:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Возведение в степень (^)");
            Console.WriteLine("6. Квадратный корень (√)");
            Console.WriteLine("7. Остаток от деления (%)");
            Console.WriteLine("8. Решение квадратного уравнения");
            Console.WriteLine("0. Выход");
            Console.WriteLine("--------------------------------");
        }

        // Базовые операции (оценка 3)
        static void Addition()
        {
            Console.WriteLine("\n--- СЛОЖЕНИЕ ---");
            Console.Write("Введите первое число: ");
            double a = GetNumber();
            Console.Write("Введите второе число: ");
            double b = GetNumber();
            double result = a + b;
            Console.WriteLine($"Результат: {a} + {b} = {result}");
        }

        static void Subtraction()
        {
            Console.WriteLine("\n--- ВЫЧИТАНИЕ ---");
            Console.Write("Введите первое число: ");
            double a = GetNumber();
            Console.Write("Введите второе число: ");
            double b = GetNumber();
            double result = a - b;
            Console.WriteLine($"Результат: {a} - {b} = {result}");
        }

        static void Multiplication()
        {
            Console.WriteLine("\n--- УМНОЖЕНИЕ ---");
            Console.Write("Введите первое число: ");
            double a = GetNumber();
            Console.Write("Введите второе число: ");
            double b = GetNumber();
            double result = a * b;
            Console.WriteLine($"Результат: {a} * {b} = {result}");
        }

        static void Division()
        {
            Console.WriteLine("\n--- ДЕЛЕНИЕ ---");
            Console.Write("Введите делимое: ");
            double a = GetNumber();
            Console.Write("Введите делитель: ");
            double b = GetNumber();

            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
                return;
            }

            double result = a / b;
            Console.WriteLine($"Результат: {a} / {b} = {result}");
        }

        // Дополнительные операции (оценка 4)
        static void Power()
        {
            Console.WriteLine("\n--- ВОЗВЕДЕНИЕ В СТЕПЕНЬ ---");
            Console.Write("Введите основание: ");
            double baseNum = GetNumber();
            Console.Write("Введите показатель степени: ");
            double exponent = GetNumber();
            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine($"Результат: {baseNum} ^ {exponent} = {result}");
        }

        static void SquareRoot()
        {
            Console.WriteLine("\n--- КВАДРАТНЫЙ КОРЕНЬ ---");
            Console.Write("Введите число: ");
            double number = GetNumber();

            if (number < 0)
            {
                Console.WriteLine("Ошибка: Нельзя извлечь корень из отрицательного числа!");
                return;
            }

            double result = Math.Sqrt(number);
            Console.WriteLine($"Результат: √{number} = {result}");
        }

        static void Modulo()
        {
            Console.WriteLine("\n--- ОСТАТОК ОТ ДЕЛЕНИЯ ---");
            Console.Write("Введите делимое: ");
            double a = GetNumber();
            Console.Write("Введите делитель: ");
            double b = GetNumber();

            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
                return;
            }

            double result = a % b;
            Console.WriteLine($"Результат: {a} % {b} = {result}");
        }

        // Решение квадратного уравнения (оценка 5)
        static void QuadraticEquation()
        {
            Console.WriteLine("\n--- РЕШЕНИЕ КВАДРАТНОГО УРАВНЕНИЯ ---");
            Console.WriteLine("Уравнение вида: ax² + bx + c = 0");

            Console.Write("Введите коэффициент a: ");
            double a = GetNumber();

            if (a == 0)
            {
                Console.WriteLine("Ошибка: Коэффициент a не может быть равен нулю!");
                return;
            }

            Console.Write("Введите коэффициент b: ");
            double b = GetNumber();
            Console.Write("Введите коэффициент c: ");
            double c = GetNumber();

            // Вычисление дискриминанта
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант D = {discriminant}");

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Уравнение имеет два различных корня:");
                Console.WriteLine($"x₁ = {x1}");
                Console.WriteLine($"x₂ = {x2}");
            }
            else if (discriminant == 0)
            {
                // Один корень
                double x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет один корень:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                // Комплексные корни
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Уравнение имеет комплексные корни:");
                Console.WriteLine($"x₁ = {realPart} + {imaginaryPart}i");
                Console.WriteLine($"x₂ = {realPart} - {imaginaryPart}i");
            }
        }

        static double GetNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Ошибка! Введите корректное число: ");
                }
            }
        }
    }
}