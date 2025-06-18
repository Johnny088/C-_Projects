
using System.Numerics;
using System.Text;

namespace _03_String
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
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
            Console.WriteLine("temp  char []--------->");
            foreach (string s in temp)                                         // getting result
            {
                Console.Write(s);                                        // everything is ok, it's need 
            }
            Console.WriteLine();
            //Console.WriteLine($"temp: {temp,36}");
            second = string.Concat(temp);
            Console.WriteLine($"Second: {second,40}");
            string second2 = second.ToLower();
            Console.WriteLine($"Second lower: {second2,34}");       //lower
            char[] five = second2.ToCharArray();

            Array.Reverse(five);
            Console.Write("reversssssssss: ");
            string reverse = "";
            foreach (char c in five)
            {
                Console.Write(c);
                reverse = reverse + c;
            }
            Console.WriteLine();
            Console.WriteLine($"first: {second2}");
            Console.WriteLine($"revers: {reverse}");
            if (reverse == second2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("this is palindrome");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It's not palindrome.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            //foreach (string s in temp)
            //{
            //    Console.Write(s);
            //}
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task3.\nДано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.");
            string message = "Визначте відсоткове відношення малих";
            Console.ForegroundColor = ConsoleColor.Cyan;
            int lower = 0, upper = 0, total = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLower(message[i]))
                {
                    lower++;
                }
                if (Char.IsUpper(message[i]))
                {
                    upper++;
                }

            }
            total = message.Length;
            Console.WriteLine($"number of letters is: {total} \nnumber of upper letters is: {upper} \nnumber of lower letters is: {lower}");
            Console.WriteLine();
            Console.WriteLine("percent of upper characters:" + (upper * 100 / total) + "%");
            Console.WriteLine("percent of lower characters:" + (lower * 100 / total) + "%");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task4.\nДано масив слів. Замінити останні три символи слів, що мають обрану довжину, на символ \"$\".\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] firth = new string[] { "some", "words", "needed", "for", "homework" };
            Console.WriteLine("Enter the number of the length of the words");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < firth.Length; i++)
            {
                {
                    if (firth[i].Length == length)
                    {
                        firth[i] = firth[i].Substring(0, length - 3);
                        firth[i] += "$";
                    }
                }
            }
            foreach (string word in firth)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task5.\nЗнайти слово, що стоїть в тексті під певним номером, і вивести його першу буквy.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] temp2 = { "some", "words", "needed", "for", "homework" };
            Console.Write($" our array is ---------> ");
            foreach (string word in temp2)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the number from 0 to 4: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int number = int.Parse(Console.ReadLine()!);
            if (number < 0 || number > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your number is out of range.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"your letter of the word is: {temp2[i][0]}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task5.\nДано рядок слів, розділених пробілами. Між словами може бути кілька пробілів, на початку і вкінці рядка також можуть бути пробіли. Ви повинні змінити рядок так, щоб на початку і вкінці пробілів не було, а слова були розділені поодиноким символом \"*\" (зірочка).");
            string temp5 = "A man, a?  plan,  a!  canal,   Panama!!!!!";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Original---->>>>>>>>  {temp5}");                // first need to get reed of spaces and symbols
            string[] temp55 = temp5.Split(new char[] { ',', '!', '.', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries); //first step making a new variable to split this array like a char[]
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("After spliting:   ");
            foreach (string i in temp55)
            {
                Console.Write(i);                    // we just got characters without any symbols or spaces.
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nThe type of the new array ----> {temp55}"); // checking the type, and we get String[]
            temp5 = null;                                                     //garbage collector get rid of the array later...
            temp5 = string.Join("*", temp55);                                 // The final step we join string[] to just string with the separator "*"..
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"result is----> {temp5}");                     // everything is working
            Console.ResetColor();

            Console.WriteLine("Task6.\tКористувач вводить слова, поки не буде введено слово з символом крапки вкінці. Сформувати з введених слів рядок, розділивши їх комою з пробілом. Застосувати StringBuilder.");
            StringBuilder builder = new StringBuilder();
            int key;
            string word1;
            do
            {

                word1 = Console.ReadLine()!;
                if (word1.Contains("."))
                {
                    builder.Append(word1);
                    Console.WriteLine(builder);
                    break;
                }
                else
                    builder.Append(word1);



            } while (true);
        }
    }


}
