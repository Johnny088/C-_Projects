using System.Runtime.InteropServices.Marshalling;
using static System.Net.Mime.MediaTypeNames;

namespace _18_01_Files
{
    internal class Program
    {
        static void OddEvenToFile(int[] arr)
        {
            string odd = @"f:\Test\Odd.txt";
            string even = @"f:\Test\Even.txt";
            var oddPath = new FileInfo(odd);
            var evenPath = new FileInfo(even);
            if (!oddPath.Exists)
            {
                oddPath.Create();                               // files were created
            }
            if (!evenPath.Exists) 
            {
                evenPath.Create();
            }
            using (StreamWriter writerOdd = oddPath.AppendText())
            {
                foreach (var i in arr)
                {
                    if (i % 2 != 0)
                    {
                        writerOdd.Write(i + " ");
                    }
                }
            }
            using (StreamWriter writerEven = evenPath.AppendText())
            {
                foreach (var i in arr)
                {
                    if (i % 2 == 0)
                    {
                        writerEven.Write(i + " ");
                    }
                }
            }

        }
        static void AddToFile<type>(type[] arr)
        {
            printY("Enter the path to the file");
            string path = Console.ReadLine()!;
            var tempFile = new FileInfo(path);
            using (StreamWriter writer = tempFile.AppendText())
            {
                if (typeof(type) == typeof(double))
                {
                    foreach (var item in arr)
                    {
                        writer.Write($"{item:F2} ");
                    }
                    writer.WriteLine();
                }
                else
                {
                    foreach (var item in arr)
                    {
                        writer.Write($"{item} ");
                    }
                    writer.WriteLine();
                }
            }
        }
        static void fillArr<Type>(Type[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random rand = new Random();

                if (typeof(Type) == typeof(int))
                {
                    object value = rand.Next(10,99);           // 
                    arr[i] = (Type)value;
                }
                if (typeof(Type) == typeof(double))
                {
                    object value = rand.NextDouble() + rand.Next(10, 98);           // 
                    arr[i] = (Type)value;
                }


            }
        }

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
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            printDC("Task1\nДодаток дозволяє користувачеві переглядати вміст файлу. " +
                "\r\nКористувач вводить шлях до файлу. Якщо файл існує, його вміст " +
                "\r\nвідображається на екрані. Якщо файл не існує, виведіть " +
                "\r\nповідомлення про помилку.");
            #region MyRegion
            printY("My test");
            DirectoryInfo dir = new DirectoryInfo(@"f:\Test");   //If you don't have the disk "f" you definitely get the mistake
            if (!dir.Exists)
            {
                dir.Create();
            }
            else
                printR("The folder is already exists");

            var file1 = new FileInfo(dir + @"\Test.txt");
            if (!file1.Exists)
            {
                file1.Create();
            }
            else
                printR("The file already exists");
            using (StreamWriter writer = file1.AppendText())    // open the stream for writing the file
            {
                writer.WriteLine("Hello, World");
            }
            printG("Item was added");
            using (StreamReader reader = new StreamReader(file1.OpenRead()))    // open the stream for reading the file.
            {

                var text = reader.ReadToEnd();
                printC(text);
            }
            printY("Test end");
            #endregion


            printC("enter the path of the file you wanna read");
            string path = Console.ReadLine()!; // f:\Test\Test.txt
            var file2 = new FileInfo(path);

            if (!file2.Exists)
            {
                printR("your file doesn't exist");
            }
            else
            {
                using (StreamReader reader2 = new StreamReader(file2.OpenRead()))    // open the stream for reading the file.
                {

                    var text2 = reader2.ReadToEnd();
                    printC(text2);
                }
                printG("Item was added");

            }

            printDC("Task2. \nКористувач вводить значення елементів масиву з клавіатури.\nДодаток надає можливість зберігати вміст масиву у файл.");
            printY("Enter the text to add to the file");
            string temp = Console.ReadLine()!;
            using (StreamWriter writer = file2.AppendText())
            {
                writer.WriteLine(temp);
            }
            printDC("Task3. \nДодайте до другого завдання можливість завантажувати масив із файлу."); // f:\Test\Test.txt   working with the same file

            int[] ints = new int[10];
            double[] doub = new double[10];

            fillArr(ints);                          // filling the arrays out
            fillArr(doub);
            //writing to the file
            AddToFile(ints);
            AddToFile(doub);
            int[] ints2 = new int[500];
            fillArr(ints2);
            OddEvenToFile(ints2);
            Console.ResetColor();

        }
    }
}
