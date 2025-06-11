using System.Transactions;

namespace _01_IntroToDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("task1"); //<--- cw + tab
            Console.WriteLine("t's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble\nBjarne Stroustrup");
            Console.WriteLine("Task2\n\tEnter 5 numbers please.");
            int num1 = int.Parse(Console.ReadLine()!);
            int num2 = int.Parse(Console.ReadLine()!);
            int num3 = int.Parse(Console.ReadLine()!);
            int num4 = int.Parse(Console.ReadLine()!);
            int num5 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("the sum of the elements is: " + (num1 + num2 + num3 + num4 + num5));
            Console.WriteLine($"the multiply of the elements is: {num1 * num2 * num3 * num4 * num5}");
            int min, max;
            //min
            if(num1<=num2 && num1<=num3 && num1<=num4 && num1<=num5)
            {
                min = num1;
            }
            else if(num2 <= num1 && num2 <= num3 && num2 <= num4 && num2 <= num5)
            {
                min = num2;
            }
            else if (num3 <= num1 && num3 <= num2 && num3 <= num4 && num3 <= num5)
            {
                min = num3;
            }
            else if (num4 <= num1 && num4 <= num2 && num4 <= num1 && num4 <= num5)
            {
                min = num4;
            }
            else
            {
                min = num5;
            }
            // max
            if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
            {
                max = num1;
            }
            else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
            {
                max = num2;
            }
            else if (num3 >= num1 && num3 >= num2 && num3 >= num4 && num3 >= num5)
            {
                max = num3;
            }
            else if (num4 >= num1 && num4 >= num2 && num4 >= num1 && num4 >= num5)
            {
                max = num4;
            }
            else
            {
                max = num5;
            }
            int number3;
            Console.WriteLine($"min of the numbers are: {min}");
            Console.WriteLine($"max of the numbers are: {max}");
            Console.WriteLine("task3\n\tEnter the number with length 6");
            number3 = int.Parse( Console.ReadLine()! );
            Console.WriteLine("The revers is: " +(number3%10)+(number3%100/10)+(number3%1000/100)+(number3%10000/1000)+(number3%100000/10000)+(number3/100000));
            Console.WriteLine("Task4\n\tFibonacci");
            Console.WriteLine("Enter the number of Fibonacci range");
            //int number = int.Parse(string); //Doesn't work, why?
            //Console.WriteLine(number + "!!!!");
            //Console.WriteLine(number + 10 + "!!!!");
            number3 = 0;
            int number4 = int.Parse( Console.ReadLine()! );
            int i = 0;
            int j = 1;
            while(number3 < number4)
            {
                number3 = i + j;
                if (number3 < number4)
                Console.Write(number3 + " ");
                i = j;
                j=number3;
            }
            Console.WriteLine("\nTask5");
            int a = 3;
            int b = 7;
            while(a <= b)
            {
                for (int step = 0; step < a; step++)
                {
                    Console.Write(a + " ");
                }
                a++;
                Console.WriteLine();
            }
            string symbol;
            Console.WriteLine("task6\n\tEnter the Symbol");
            symbol = Console.ReadLine()!;
            Console.WriteLine("1 - horizontal line\n2 - vertical line");
            int number5 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the length of the line");
            int number6 = int.Parse(Console.ReadLine()!);
            if (number5 == 1)
            {
                for (int step = 0; step < number6; step++)
                {
                    Console.Write(symbol + " ");
                }

            }
            else if (number5 == 2)
            {
                Console.WriteLine(symbol);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }
    }
}
