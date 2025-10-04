class Program
{
    static void Main()
    {
        // Задача 1: Перевод из двоичной системы в десятичную
        Console.Write("Введите двоичное число: ");
        string binary = Console.ReadLine();

        int decimalResult = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            decimalResult = decimalResult * 2 + (binary[i] - '0');
        }
        Console.WriteLine($"Десятичное: {decimalResult}");

        // Задача 2: Перевод из десятичной системы в двоичную
        Console.Write("Введите десятичное число: ");
        int number = int.Parse(Console.ReadLine());

        string binaryResult = "";
        int temp = number;
        while (temp > 0)
        {
            binaryResult = (temp % 2) + binaryResult;
            temp /= 2;
        }
        binaryResult = binaryResult == "" ? "0" : binaryResult;
        Console.WriteLine($"Двоичное: {binaryResult}");

        // Задача 3: Расчет времени доставки
        Console.Write("Введите часы: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Введите время доставки в минутах: ");
        int delivery = int.Parse(Console.ReadLine());

        int totalMinutes = hours * 60 + minutes + delivery;
        int resultHours = (totalMinutes / 60) % 24;
        int resultMinutes = totalMinutes % 60;

        Console.WriteLine($"Время доставки: {resultHours:D2}:{resultMinutes:D2}");
    }
}