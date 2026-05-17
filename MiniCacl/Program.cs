namespace MiniCacl
{
    internal class Program
    {
        static void Main()
        {

        vvod1:
                        
            Console.Write("Введите первое число: ");
            string inputFirstValue = Console.ReadLine() ?? string.Empty;
            bool resultFirstInput = decimal.TryParse(inputFirstValue, out decimal firstValue);

            if (resultFirstInput == false)
            {
                Console.WriteLine("Введено не число");
                goto vvod1;
            }

        vvod2:

            Console.Write("Введите второе число: ");
            string inputSecondValue = Console.ReadLine() ?? string.Empty;
            bool resultSecondInput = decimal.TryParse(inputSecondValue, out decimal secondValue);

            if (resultSecondInput == false)
            {
                Console.WriteLine("Введено не число");
                goto vvod2;
            }

            Console.Write("Выберите операцию (+, -, *, /): ");
            string operationType = Console.ReadLine() ?? string.Empty;

            switch (operationType)
            {
                case "+":
                    Console.WriteLine($"Результат: {firstValue + secondValue}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {firstValue - secondValue}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {firstValue * secondValue}");
                    break;
                case "/":
                    if (secondValue == 0)
                        Console.WriteLine("Ошибка: деление на 0");
                    else
                        Console.WriteLine($"Результат: {firstValue / secondValue}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}
