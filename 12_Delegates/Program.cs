namespace _12_Delegates
{
    
    internal class Program
    {
        static void MainMenu()
        {
            int key;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Menu: \n1 - number of the negative elements \n2 - turning all the negative numbers to 0 \n3 - sorting an array all even numbers in the beginning" +
                "");
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
