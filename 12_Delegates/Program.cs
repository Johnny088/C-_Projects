namespace _12_Delegates
{

    internal class Program
    {
        public delegate void DelegateMenu(int[] arr);
        static void MainMenu(int[] arr)
        {
            int key1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Menu: \n1 - Array calculation \n2 - Changing Array \n" +
                "");
            key1 = int.Parse(Console.ReadLine()!);
            DelegateMenu[] delegateMenus = { menu1, menu2 };
            delegateMenus[key1 - 1]?.Invoke(arr);
        }

        static void menu1(int[] arr)
        {

            Console.WriteLine("Type: \n1 - getting all negative numbers \n2 - the sum of the array \n3 the number of the Simple numbers");
            int act = int.Parse(Console.ReadLine()!);
            DelegateMenu[] delegateMenus1 = { Negative, TotalSum, SimpleNumbers };
            delegateMenus1[act - 1]?.Invoke(arr);
        }
        static void menu2(int[] arr)
        {
            Console.WriteLine("Type: \n1 - Turning all negative numbers to 0 \n2 - sorting the array \n3 - putting all even numbers in the beginning");
            int act = int.Parse(Console.ReadLine()!);
            DelegateMenu[] delegatemenu3 = { Changenegative, SortArr, ReplaceArr};
            delegatemenu3[act - 1]?.Invoke(arr);
        }
        #region menu1 function
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
                for (int j = 2; j < arr[i]; j++)
                {

                    if (arr[i] % j == 0)
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
        #endregion

        
        #region menu2
        static void Changenegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;
            }
            ShowArr(arr);
        }

        static void SortArr(int[]arr)
        {
            Array.Sort(arr);
            ShowArr(arr);
        }

        static void ReplaceArr(int[]arr)
        {
            
            int[] temp3 = new int[arr.Length];
            //temp3 = arr;
            //Console.WriteLine(Object.ReferenceEquals(arr,temp3));
            Array.Copy(arr, temp3, arr.Length);
            Console.WriteLine(Object.ReferenceEquals(arr, temp3));
            int j = 0;
            for (int i = 0;i < temp3.Length;i++)
            {
                if (temp3[i] % 2 ==0)
                {
                    arr[j] = temp3[i];
                    j++;
                }

            }
            for (int i = 0; i<temp3.Length; i++)
            {
                if (temp3[i] % 2 != 0)
                {
                    arr[j] = temp3[i];
                    j++;
                }
            }
            ShowArr(arr);
        }




        #endregion
        #region Rest of functions
        static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void FillArr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(81) - 40;
            }
        }
        #endregion




        static void Main(string[] args)
        {
            int[] arr = new int[20];
            FillArr(arr);
            Console.ForegroundColor = ConsoleColor.Yellow;
            ShowArr(arr);
            MainMenu(arr);
        }
    }
}   
