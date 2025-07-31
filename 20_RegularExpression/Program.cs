using System.Text.RegularExpressions;

namespace _20_RegularExpression
{
    internal class Program
    {
        static void SearchFromFile(FileInfo path)
        {
            string temp = "";
            string patternDouble = (@"(\d+\.\d+|\d+\,\d+)");
            MatchCollection matchDouble;
            if (!path.Exists)
            {
                path.Create();
                printG("the file was created");
            }
            using (StreamReader reader = new StreamReader(path.OpenRead()))
            {
                temp = reader.ReadToEnd();
                matchDouble = Regex.Matches(temp, patternDouble);
            }
            printCollection(matchDouble);
        }
        static void GetIntFromFile(FileInfo path, ref int[] arr)
        {
            string patternInt = (@" \d+ ");
            string temp;
            MatchCollection matchInt;
            if (!path.Exists)
            {
                path.Create();
                printG("the file was created");
            }
            using(StreamReader reader = new StreamReader(path.OpenRead()))
            {
                temp = reader.ReadToEnd();
                matchInt = Regex.Matches(temp, patternInt);
            }
            CollToInt(matchInt, ref arr);

        }
        static void CollToInt(MatchCollection coll, ref int[] arr)
        {
           int[] arr1 = new int[coll.Count()];
            int i = 0;
            foreach (Match item in coll)
            {
                arr1[i] = int.Parse(item.Value);
                i++;
            }
            arr = new int[arr1.Length];
            arr = arr1;
            
        }
        static void ShowArray<T>(T[] arr)
        {
            printC("");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void printCollection(MatchCollection coll)
        {
            printC("");
            foreach (Match match in coll)
            {
                Console.WriteLine($"Value: {match.Value}");
            }
            printG("The file was read");
        }
        #region print
        static void printR<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        static void printC<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
        }
        static void printDC<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(message);
        }
        static void printY<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
        static void printG<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        static void printDY<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
        }
        static void reset()
        {
            Console.ResetColor();
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            printDY("Task1. \nПрограма повинна знайти в текстовому файлі всі дробові числа. " + 
                "\r\nДробовим вважається число, в якого є значення після символу ." +
                "\r\n(крапка) або ,(кома).");
            string testFile = @"test.txt";
            var path = new FileInfo(testFile); // I had created the file before now.
            printDC("Data of the file is ===> '2.12 some text 5.12 then 7,15 556 asdf asdf1232 afsd2.1 safd226,34 26 39' ");
            SearchFromFile(path);
            printDY("Task2. Написати програму, яка буде зчитувати вміст текстового файлу \r\nта записувати в колекцію типу int всі знайдені числа в тексті.");
            int[] arr = null;
            GetIntFromFile(path, ref arr);
            ShowArray(arr);
            reset();

        }
    }
}
