using System.Collections.Generic;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _13_02_Events_Extensions
{
    static class StringExtension
    {
        public static bool IfPalindrome(this string text)
        {
            string temp = text;
            //string text = "A man, a plan, a canal,?! Panama 123";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine($"Your origin text: \n\t{text}");
            string[] testcopy = text.Split(new char[] { ' ', ',', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries); //turning the copy to char[], and splitting all symbols
            string testcopy2 = string.Concat(testcopy).ToLower();                 //getting result turned to Lowercase and without symbols or spaces
            //Console.WriteLine(testcopy2);
            text = testcopy2;
            //Console.WriteLine(text);
            Array.Reverse(testcopy);
            char[] testrevers = testcopy2.ToCharArray();
            string revers = "";
            for (int i = testrevers.Length - 1; i >= 0; i--)
            {
                revers += testrevers[i];
            }
            //Console.WriteLine($"revers: {revers}");
            if (revers == text)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"whether your text: \n\t{temp} is palindrome: ");
                Console.ForegroundColor = ConsoleColor.Green;
                return true;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"whether your text: \n\t{temp} is palindrome: ");
                Console.ForegroundColor = ConsoleColor.Green;
                return false;
            }
                

        }
        public static string CezarCode(this string text, int number)
        {
            if (string.IsNullOrEmpty(text)) return "Something went wrong";
            char [] temp = text.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = (char) (temp[i] + number);
            }
            Console.WriteLine();
            text = new string(temp);
            return text;
        }
    }
    static class ArrayExtension
    {
        public static int TheSamePoints<T>(this T[] value)
        {
            if (value == null) return -1;
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i+1; j < value.Length; j++)
                {
                    if (value[i]!.Equals(value[j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Task 1. Need to make extension if the test is a palindrome");
            string test = "A man, a plan, a canal,?! Panama ";
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine(test.IfPalindrome()); 
            Console.ResetColor();
            test = "maDAm";
            Console.WriteLine(test.IfPalindrome()); 
            Console.ResetColor();
            test = "123";
            Console.WriteLine(test.IfPalindrome()); 
            Console.ResetColor();
            test = "123321";
            Console.WriteLine(test.IfPalindrome()); 
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Task 2. Need to make a Cezar code for the text");
            Console.ForegroundColor= ConsoleColor.Cyan;
            test = "Hello World";
            Console.Write($"Origin: ====> {test} \nCode: ====> ");
            Console.ForegroundColor= ConsoleColor.Green;
            string cezar = test.CezarCode(5);
            Console.WriteLine(cezar);
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Task 3. Need to make an Array which will be looking for equal values and giving the number of it ");
            Console.ForegroundColor= ConsoleColor.Cyan;
            int Result = 0;
            string[] names = { "Bob", "John", "Kris", "Mateo", "Bob", "Johnny", "John" }; 
            int[] numbers = [11, 2, 3, 22, 5, 11, 7, 8, 11, 22];
            Console.WriteLine("{ \"Bob\", \"John\", \"Kris\", \"Mateo\", \"Bob\", \"Johnny\", \"John\" }");
            Console.WriteLine(names.TheSamePoints());
            Console.WriteLine("[11, 2, 3, 22, 5, 11, 7, 8, 11, 22]");
            Console.WriteLine(numbers.TheSamePoints());

            Console.ResetColor();
        }
    }
}
