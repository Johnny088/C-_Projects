

namespace _09_Interfaces
{
    interface Ioutput
    {
        void show();
        void show(string info);
    }
    interface Imath
    {
        int Max();
        int Min();
        float avr();
        bool Search(int value);
    }
    interface Isort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isASC);
    }
    class Array1: Ioutput, Imath, Isort
    {
        public int[] Arr { get; set; }
        

        public Array1()
        {
            Arr = Array.Empty<int>();
        }
        public Array1(int value)
        {
            Arr = new int[value];
        }
        public Array1(params int[] value)
        {
            Arr = value;
        }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void show(string info)
        {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(info + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public int Max()
        {
            return Arr.Max();
        }

        public int Min()
        {
            return Arr.Min();
        }

        public float avr()
        {
            return (float) Arr.Average();
        }

        public bool Search(int value)
        {
            foreach (int i in Arr)
            {
                if (i == value) return true;
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(Arr);
        }

        public void SortDesc()
        {
            Array.Sort(Arr);
            Array.Reverse(Arr);
        }

        public void SortByParam(bool isASC)
        {
            if (!isASC)
            {
                SortDesc();
            }
            else
            {
                SortAsc();
            }

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Array1 arr1 = new Array1();
            Array1 arr1 = new Array1(10);
            Array1 arr2 = new Array1(45, 45, 78, 96, 56, 7487, 54, 78, 45, 78, 45, 12, 45, 85);
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Array 1");
            arr1.show();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Array 2");
            arr2.show();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Array 1 Show info");
            arr1.show("Some text for the arr1");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Array 2 Show info");
            arr2.show("Some text for the arr2");
            int max = arr2.Max();
            int min = arr2.Min();
            float avr1 = arr2.avr();
            bool search1 = arr2.Search(54);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Interface Imath");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The max of the arr2 is {max}");
            Console.WriteLine($"The max of the arr2 is {min}");
            Console.WriteLine($"The Average of the arr2 is {avr1}");
            Console.WriteLine($"Whether 54 is in the array  {search1}");
            search1 = arr2.Search(256);
            Console.WriteLine($"Whether 256 is in the array  {search1}");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Isort \n\tSortAsc");
            arr2.SortAsc();
            arr2.show();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\tSortDesc");
            arr2.SortDesc();
            arr2.show();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\tSortByParam true");
            arr2.SortByParam (true);
            arr2.show();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\tSortByParam false");
            arr2.SortByParam (false);
            arr2.show();

            Console.ResetColor();
        }
    }
}
