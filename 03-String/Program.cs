
namespace _03_String
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;
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
            first = "A man, a plan, a canal, Panama"; // original
            Console.WriteLine($"Origin {first,50}"); // just showing
            string[] temp = first.Split(new char[] { ' ', ',', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries); //turning to char[], and splitting all symbols       Temp
            Console.WriteLine("temp --------->");
            foreach (string s in temp)                                         // getting result
            {
                Console.Write(s + "");                                        // everything is ok, it's need 
            }
            Console.WriteLine();
            //Console.WriteLine($"temp: {temp,36}");
            second = string.Concat(temp);
            Console.WriteLine($"Second: {second,40}");
            string second2 = second.ToLower();
            Console.WriteLine($"Second lower: {second2,34}"); //lower
            char[] five = second2.ToCharArray();
  
            Array.Reverse(five);
            Console.Write("reversssssssss: ");
            string reverse = "";
            foreach (char c in five)
            {
                Console.Write(c);
                reverse = reverse + c;
            }
            Console.WriteLine($"first: {second2}");
            Console.WriteLine($"revers: {reverse}");
            if(reverse==second2)
            {
                Console.WriteLine("this is palindrome");
            }
            else
            {
                Console.WriteLine("It's not palindrome.");
            }

                //foreach (string s in temp)
                //{
                //    Console.Write(s);
                //}
                Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task3.\nДано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task4.\nДано масив слів. Замінити останні три символи слів, що мають обрану довжину, на символ \"$\".\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] firth = new string[] { "some", "words", "needed", "for", "homework" };
            foreach(string i  in firth)
            {

            }


        }
    }
}
