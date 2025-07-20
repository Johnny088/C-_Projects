namespace _17_Generics
{
    internal class Program
    {
        static T Maximum<T>(T a, T b, T c)where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max)>0)
                max = b;
            if (c.CompareTo(max)>0)
                max = c;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"a: {a} b: {b} c: {c}");
            return max;
            
        }
        static T Minimum<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
                min = b;
            if (c.CompareTo(min) < 0)
                min = c;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"a: {a} b: {b} c: {c}");
            return min;

        }
        static void print(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(message);
        }
        static void printY(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }

        static T sum<T> (T[] arr)
        {
            T sum = default;
            foreach (T item in arr)
            {
                sum += (dynamic) item;
            }
            return sum;


        }
        static void Main(string[] args)
        {

            print("----------------------------------Maximum----------------------------------");
            int a = 15, b = 32, c = 25;
            int max = Maximum(a, b, c);
            printY($"The max of these numbers is: {max}");
            print("----------------------------------Minimum----------------------------------");
            int min = Minimum(a, b, c);
            printY($"The max of these numbers is: {min}");
            int[] arr = new int[15];
            Random random = new Random();
            print("----------------------------------Array----------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10, 99);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            var sum1 = sum(arr);
            printY($"The sum of the array is: {sum1}");


            Console.ResetColor();
        }
    }
}
