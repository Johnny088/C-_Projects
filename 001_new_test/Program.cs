using System.Threading.Channels;

namespace _001_new_test
{
    class test
    {
        public event Action action;
        public void StartAction()
        {
            action();
        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //test test1 = new test();
            ////test1.action += Test1_action;
            //test1.action += Console.WriteLine;
            //test1.action += delegate () { Console.BackgroundColor = ConsoleColor.DarkBlue; };
            //test1.action += delegate () { Console.WriteLine("test"); };
            //test1.action += () => { Console.Beep(500, 500); };
            //test1.action += delegate () { Console.Beep(600, 500); };

            //test1.StartAction();
            //string text = "textsad";
            //char [] chars = text.ToCharArray();
            //Console.WriteLine(text);
            //Console.WriteLine(chars);
            //Console.WriteLine(chars[5]);
            //Console.WriteLine(text[5]);
            //Console.WriteLine(text.GetType()); 
            //Console.WriteLine(chars.GetType());
            //for (int i = 0; i < chars.Length; i++)
            //{
            //   chars[i] = (char) (chars[i] + 3);
            //}
            int[] arr = { 5, 7, 14, 21, -32, 56, -89, 58, -74 };
            //List<int> list = new List<int>() { 5, 7, 14, 21, 32, 56, 89, 58, 74 };

            //var query = from i in arr select i;
            //int[] query = from i in arr select i;
            //Console.WriteLine("--------Copy array ------");
            IEnumerable<int> query = from i in arr select i;
            foreach (int i in query)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------Original array ------");
            arr[0] = 100;

            Console.WriteLine("--------Original array ------");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------Query array ------");
            foreach (int i in query)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            query = arr.Select(SelectInt);
            Console.WriteLine("--------Original array ------");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------Query array ------");
            foreach (int i in query)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static int SelectInt(int i)
        {
            return i * -1;
        }

    }
}
