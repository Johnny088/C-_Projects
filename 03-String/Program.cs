namespace _03_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("task1\nВставити в задану позицію рядка інший рядок.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string first = new string("Some text for my homework"); 
            Console.WriteLine(first);
            string second = new string("Put me into the first string ");
            Console.WriteLine(second);
            string third = first.Insert(10, second);
            Console.WriteLine(third);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("task2\nВизначити, чи є рядок паліндромом. Паліндром – це число, слово або фраза, яка однаково читається в обох напрямках.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            
        }
    }
}
