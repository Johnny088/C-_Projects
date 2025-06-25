

namespace _06_ExceptionNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number2 = 0;
            int number1;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task1. \nКористувач вводить до рядка з клавіатури набір сим-" +
                "\r\nволів від 0-9. Необхідно перетворити рядок на число ціло-" +
                "\r\nго типу. Передбачити випадок виходу за межі діапазону," +
                "\r\nякий визначається типом int. Використовуйте механізм" +
                "\r\nвиключень.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the numbers: ");
            try
            {
                number1 = int.Parse(Console.ReadLine()!);
                number2 = number1;
            }
            
            catch (FormatException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            catch (OverflowException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (number2 !=0)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong");
            }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task2. \nСтворіть клас «Кредитна картка». Вам необхідно зберіга-" +
                "\r\nти інформацію про номер картки, ПІБ власника, CVC, дату" +
                "\r\nзавершення роботи картки і т.д. Передбачити механізми" +
                "\r\nініціалізації полів класу. Якщо значення для ініціалізації" +
                "\r\nнеправильне, генеруйте виняток.");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.Write("Enter the number of the card: ");
            string testnumber = Console.ReadLine()!;
            long CardNumber;
            if (testnumber.Length == 16)
            {
                try
                {
                    CardNumber = long.Parse(testnumber);
                    Console.WriteLine(CardNumber);
                }
                catch (FormatException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong");
                Console.ResetColor();
            }
        }
    }
}
