using System.Runtime.InteropServices.Marshalling;
using static System.Net.Mime.MediaTypeNames;

namespace _18_01_Files
{
    internal class Program
    {
        static void FileStatistics(FileInfo path)
        {
            string temp;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            char[] consonants = {'b', 'c', 'd', 'f', 'g', 'h', 'j','k','l','m' };
            char[] sentences = { '.', '!', '?' };
            int numberOfSentences = 0,
                upper = 0,
                lower = 0,
                numberOfVowels = 0,
                numberOfConsonants = 0,
                numberOfDigit = 0;
            if (!path.Exists)
            {
                path.Create();
                printG("the file was created");
            }
            using (StreamReader reader = new StreamReader(path.OpenRead()))
            {
                temp = reader.ReadToEnd();
            }
            foreach (char item in temp)
            {
                if (sentences.Contains(item))
                {
                    numberOfSentences++;
                }
                if(char.IsUpper(item))
                {
                    upper++;
                }
                if (char.IsLower(item))
                {
                    lower++;
                }
                if (char.IsLetter(item))
                {
                    if (vowels.Contains(char.ToLower(item)))
                        {
                            numberOfVowels ++;
                        }
                    else
                        numberOfConsonants ++;
                }
                if(char.IsDigit(item))
                {
                    numberOfDigit ++;
                }
            }
            printG($"The number of the sentences is {numberOfSentences} \nThe number of the Upper case is {upper} \nThe number of the lower case is {lower}" +
                $"\nThe number of the vowels is {numberOfVowels} \nThe number of the consonants is {numberOfConsonants} \nThe number of digit is {numberOfDigit}");
        }
        static void SearchFromFile(FileInfo path)
        {
            string word;
            string[] tempArr;

            int originCount =0, reverseCount = 0;
            if (!path.Exists)
            {
                path.Create();
                printG("the file was created");
            }
            using (StreamReader reader = new StreamReader(path.OpenRead()))
            {
                tempArr = reader.ReadToEnd().Split(new char []{ ' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            }
            
            printY("give me the word you want to find");
            word = Console.ReadLine()!;
            string wordReverse = new string(word.Reverse().ToArray());
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (word.Contains(tempArr[i]))
                {
                    originCount++;
                    printDY($"The word '{word}' was found at number {i+1} in the file");
                }
                if (wordReverse.Contains(tempArr[i]))
                {
                    reverseCount++;
                    printC($"The revers of the word '{word}' was found at number {i +1} in the file");
                }
            }
            foreach (string temp in tempArr)
            {
                
            }
            printG($"The word {word} was found {originCount} \tand the reverse of the {word} was found {reverseCount} ");
            

        }
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
            printG("Files were written");
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
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //printDC("Task1\nДодаток дозволяє користувачеві переглядати вміст файлу. " +
            //    "\r\nКористувач вводить шлях до файлу. Якщо файл існує, його вміст " +
            //    "\r\nвідображається на екрані. Якщо файл не існує, виведіть " +
            //    "\r\nповідомлення про помилку.");
            //#region MyRegion
            //printY("My test");
            //DirectoryInfo dir = new DirectoryInfo(@"f:\Test");   //If you don't have the disk "f" you definitely get the mistake
            //if (!dir.Exists)
            //{
            //    dir.Create();
            //}
            //else
            //    printR("The folder is already exists");

            //var file1 = new FileInfo(dir + @"\Test.txt");
            //if (!file1.Exists)
            //{
            //    file1.Create();
            //}
            //else
            //    printR("The file already exists");
            //using (StreamWriter writer = file1.AppendText())    // open the stream for writing the file
            //{
            //    writer.WriteLine("Hello, World");
            //}
            //printG("Item was added");
            //using (StreamReader reader = new StreamReader(file1.OpenRead()))    // open the stream for reading the file.
            //{

            //    var text = reader.ReadToEnd();
            //    printC(text);
            //}
            //printY("Test end");
            //#endregion


            //printC("enter the path of the file you wanna read");
            //string path = Console.ReadLine()!; // f:\Test\Test.txt
            //var file2 = new FileInfo(path);

            //if (!file2.Exists)
            //{
            //    printR("your file doesn't exist");
            //}
            //else
            //{
            //    using (StreamReader reader2 = new StreamReader(file2.OpenRead()))    // open the stream for reading the file.
            //    {

            //        var text2 = reader2.ReadToEnd();
            //        printC(text2);
            //    }
            //    printG("Item was added");

            //}

            //printDC("Task2. \nКористувач вводить значення елементів масиву з клавіатури.\nДодаток надає можливість зберігати вміст масиву у файл.");
            //printY("Enter the text to add to the file");
            //string temp = Console.ReadLine()!;
            //using (StreamWriter writer = file2.AppendText())
            //{
            //    writer.WriteLine(temp);
            //}
            //printDC("Task3. \nДодайте до другого завдання можливість завантажувати масив із файлу."); // f:\Test\Test.txt   working with the same file

            //int[] ints = new int[10];
            //double[] doub = new double[10];

            //fillArr(ints);                          // filling the arrays out
            //fillArr(doub);
            ////writing to the file
            //AddToFile(ints);
            //AddToFile(doub);

            //printDC("Task4. \nДодаток генерує випадковим чином 10000 цілих чисел. " +
            //    "\r\nЗбережіть парні числа в один файл, непарні – в інший. За " +
            //    "\r\nпідсумками роботи додатка потрібно відобразити статистику на " +
            //    "\r\nекрані");
            //int[] ints2 = new int[500];
            //fillArr(ints2);
            //OddEvenToFile(ints2);

            printDC("Task5. Dодаток надає користувачеві можливість пошуку по файлу:" +
                "\r\n Пошук заданого слова. Додаток показує, чи знайдено слово. " +
                "\r\nКрім того, відображається інформація про те, де знайдено " +
                "\r\nзбіг." +
                "\r\n Пошук кількості входження слова у файл. Додаток " +
                "\r\nвідображає кількість знайденого слова." +
                "\r\n Пошук заданого слова у зворотному порядку. Наприклад, " +
                "\r\nкористувач шукає слово «moon». Це означає, що додаток " +
                "\r\nшукає слово «moon» у зворотному напрямку: «noom». За " +
                "\r\nрезультатами пошуку, додаток відображає кількість " +
                "\r\nвходжень." +
                "\r\n \n");
            string TestTask5 = @"f:\Test\Task5.txt";                   // The file was created before the compilation by myself and it's ready to test
            var pathTask5 = new FileInfo(TestTask5);
            SearchFromFile(pathTask5);

            printDC("Task6. \nКористувач вводить шлях до файлу. Додаток відображає" +
                "\r\nстатистичну інформацію про файл:" +
                "\r\n кількість речень;" +
                "\r\n кількість великих літер;" +
                "\r\n кількість маленьких літер;" +
                "\r\n кількість голосних літер;" +
                "\r\n кількість приголосних літер;" +
                "\r\n кількість цифр");
            FileStatistics(pathTask5);                                   //I use the same file from previous task
            Console.ResetColor();

        }
    }
}
