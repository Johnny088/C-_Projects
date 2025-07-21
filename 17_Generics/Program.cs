

namespace _17_Generics
{
    class MyStack<type>
    {
        public Stack<type> mystack1 { get; set; }
        public MyStack()
        {
            mystack1 = new Stack<type>();
        }
        public void push(type value) { mystack1.Push(value); }
        public void pop() { mystack1.Pop(); }
        public type peek() {  return mystack1.Peek(); }
        public int count() { return mystack1.Count(); }
        public void print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in mystack1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    class MyQueue<type>
    {
        public Queue<type> Myqueue { get; set; }
        public MyQueue()
        {
            Myqueue = new Queue<type>();
        }
        public void enqueue(type value) { Myqueue.Enqueue(value); }
        public void dequeue() { Myqueue.Dequeue(); }
        public type peek() { return Myqueue.Peek(); }
        public int count() { return Myqueue.Count(); }
        public void print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in Myqueue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        #region Program
        static T Maximum<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
                max = b;
            if (c.CompareTo(max) > 0)
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
        static void print<T>(T message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(message);
        }
        static void printY<T>(T message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
        static void printC<T>(T message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
        }

        static T sum<T>(T[] arr)
        {
            T sum = default;
            foreach (T item in arr)
            {
                sum += (dynamic)item;
            }
            return sum;


        }

        #endregion

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
            printC("----------------------------------Generic Class stack----------------------------------");
            MyStack<string>  stack = new  MyStack<string>();
            stack.push("one");
            stack.push("two");
            stack.push("three");
            stack.push("four");
            print("----------------------------------Method push----------------------------------");
            stack.print();
            print("----------------------------------Method pop----------------------------------");
            stack.pop();
            stack.print();
            print("----------------------------------Method peek----------------------------------");
            printC(stack.peek());
            print("----------------------------------Method count----------------------------------");
            printC(stack.count());
            printY("----------------------------------Generic Class queue----------------------------------");
            print("----------------------------------Method Enqueue----------------------------------");
            MyQueue<string> queue = new MyQueue<string>();
            queue.enqueue("one");
            queue.enqueue("two");
            queue.enqueue("three");
            queue.enqueue("four");
            queue.print();
            print("----------------------------------Method Dequeue----------------------------------");
            queue.dequeue();
            queue.print();
            print("----------------------------------Method Peek----------------------------------");
            printC(queue.peek());
            print("----------------------------------Method Count----------------------------------");
            printC(queue.count());




            Console.ResetColor();
        }
    }
}
