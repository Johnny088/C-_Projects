using System.Xml.Serialization;

namespace LINQ
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            int[] arr1 = new int[15];
            FillOut(arr1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Int Array");
            print(arr1);

        }
    }
}
