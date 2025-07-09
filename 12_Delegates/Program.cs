namespace _12_Delegates
{
    
    internal class Program
    {
        public delegate void DelegateMenu();
        static void MainMenu()
        {
            int key1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Menu: \n1 - Array calculation \n2 - Changing Array \n" +
                "");
            key1 = int.Parse(Console.ReadLine()!);
            //if (key1 == 1) { menu1(); }
            //if (key1 == 2) { menu2(); }
            DelegateMenu[] delegateMenus = { menu1, menu2 };
            delegateMenus[key1 - 1]?.Invoke();
        }
        public delegate void DelegateMenu2(int[] arr);
        static void menu1()
        {
            Console.WriteLine();
            DelegateMenu2[] delegateMenus2 = new DelegateMenu2[] { Negative, TotalSum, SimpleNumbers };
        }
        static void menu2()
        {

        }
        static void Negative(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    count++;
            }
            Console.WriteLine($"The number of negative numbers is: {count}");

        }
        static void TotalSum(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count += arr[i];
            }
            Console.WriteLine($"The number of negative numbers is: {count}");

        }
        static void SimpleNumbers(int[] arr)
        {
            int count = 0;
            int NotSimple = 0;
            int Simple = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 1)
                {
                    NotSimple++;
                    continue;
                }
                for (int j = 2; j<arr[i]; j++)
                {
                        
                    if (arr[i] % j ==0 )
                    {
                        count++;
                        if (count == 1)
                        {
                            count = 0;
                            NotSimple++;
                            break;
                        }
                    }
                }
            }
            Simple = arr.Length - NotSimple;
            Console.WriteLine($"The number of simple numbers is: {Simple}");

        }



        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
