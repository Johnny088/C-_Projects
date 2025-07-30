using System.Xml.Serialization;

namespace LINQ
{
    internal class Program
    {
        static void FillOutBiggerRange(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(-100, 150);
            }
        }
        static void FillOut(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(-40, 40);
            }
        }
        static void print(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
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
            printDY("task1. \nДано цілочисельну послідовність. Витягти з неї всі позитивні числа, \nвідсортувавши їх по зростанню. (можна використати Where, OrderBy)");
            int[] arr1 = new int[15];
            FillOut(arr1);
            printDC("Int origin Array");
            print(arr1);
            printDC("the positive numbers of the array");
            var result = from item in arr1                // or IEnumerable<int> result = from item in arr1....
                         where item > 0
                         orderby item
                         select item;
            printC("");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            printDC("the same by using method");
            IEnumerable<int> result2 = arr1.Where(x => x > 0).OrderBy(x => x);
            printC("");
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            printDY("task1. \nДано колекцію цілих чисел. Знайти кількість позитивних двозначних елементів,\nа також їх середнє арифметичне. (Where, Avg)");
            int[] arr2 = new int[30];
            FillOutBiggerRange(arr2);
            print(arr2);
            IEnumerable<int> newResult1 = from item2 in arr2
                                          where item2 > 9 && item2 <100
                                          orderby item2
                                          select item2;
            //////////////////////////////////////////////
            int size = (from item in arr2
                        where item > 0 && item < 100
                        select item).Count();
            //////////////////////////////////////////////
            double Average = (from item in arr2
                        where item > 0 && item < 100
                        select item).Average();
            foreach (var item in newResult1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            printY($"The number of the numbers is: {size}");
            printY($"The Average of the numbers is: {Average:F2}");
            reset();
        }
    }
}
