using System.Text.Unicode;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("task 1");
            int[] arr = { 1, 2, 3, 23, 65, 12, 13 };
            int odd = 0, even = 0, unic = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j<arr.Length; j++)
                {
                    
                }
            }
            Console.WriteLine($"even: {even} \nodd: {odd} \nunic: {unic}");
            Console.WriteLine("Task 2\n\tСтворіть додаток, який відображає кількість значень у\r\nмасиві менше заданого параметра користувачем. Наприклад,\r\nкількість значень менших, ніж 7 (7 введено користувачем\r\nз клавіатури).");
            Random random = new Random();
            int[] arr2 = new int[20];
            int number;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(100);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("\nEnter the number: ");
            number = int.Parse(Console.ReadLine()!);
            foreach(int i in arr2)
            {
                if (i < number)
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"task3\nОголосити одновимірний (5 елементів) масив з назвою\r\nA i " +
                $"двовимірний масив (3 рядки, 4 стовпці) дробових чисел\r\nз назвою B. " +
                $"Заповнити одновимірний масив А числами,\r\nвведеними з клавіатури користувачем, а двовимірний\r\nмасив В — випадковими числами за допомогою циклів." +
                $"\r\nВивести на екран значення масивів: масиву А — в один\r\nрядок, масиву В — у вигляді матриці. Знайти у даних" +
                $"\r\nмасивах загальний максимальний елемент, мінімальний\r\nелемент, загальну суму усіх елементів, загальний добуток" +
                $"\r\nусіх елементів, суму парних елементів масиву А, суму\r\nнепарних стовпців масиву В.");
            int []a = new int[5];
            float [,]b = new float[3,4];
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter the number for the element {(a[i]) +1 }: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            foreach (int l in a)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();


        }
    }
}
