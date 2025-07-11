namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("task 1");
            int[] arr = { 1, 2, 3, 23, 23, 12, 13 };
            int odd = 0, even = 0, unique = 0, temp = 0;
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
            for (int i = 0; i < arr.Length -1; i++)
            {
                temp = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp++;
                    }
                    
                }
                if (temp == 0)
                {
                    unique++;
                }
            }
            Console.WriteLine($"even: {even} \nodd: {odd} \nunique: {unique}");
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
            foreach (int i in arr2)
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
            int[] a = new int[5];
            float[,] b = new float[3, 4];
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter the number for the element {(a[i]) + 1}: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write("Array a: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n" + b.Length);
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = ((float)new Random().NextDouble()) + 20;
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task4\n\tДано двовимірний масив розміром 5×5, заповне-" +
                "\r\nний випадковими числами з діапазону від –100 до 100." +
                "\r\nВизначити суму елементів масиву, розташованих між" +
                "\r\nмінімальним і максимальним елементами.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int[,] arr1 = new int[5, 5];
            int min = 0, max = 0, count = 0, sum = 0;
            min = max = arr1[0, 0];
            int maxi=0, maxj=0;
            int mini=0, minj=0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {

                    arr1[i, j] = new Random().Next(-100, 100);
                    //Console.Write((arr1[i,j],4) + " "); //Doesn't work 
                    Console.Write($"{arr1[i, j],4} ");
                    if (min > arr1[i, j])
                    {
                        min = arr1[i, j];
                        mini = i;
                        minj = j;
                    }
                    if (max < arr1[i, j])
                    {
                        max = arr1[i, j];
                        maxi= i;
                        maxj = j;
                    }
                }
                Console.WriteLine();

            }
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"min: {min} \nmax: {max}");
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"min: {mini} - {minj}");
            Console.WriteLine($"max: {maxi} - {maxj}");
            Console.ResetColor();
            temp = 0;
            if ( mini > maxi)
            {
                (mini, maxi) = (maxi, mini);
                (minj,maxj) = (maxj, minj);
                //temp = mini;
                //mini = maxi;
                //maxi = temp;
                //temp = minj;
                //minj = maxj;
                //maxj = temp;

            }
            else if(mini == maxi && minj>maxj )
            {
                (minj,maxj) = (maxj,minj);

            }
            int f = mini, s = minj;
            do
            {
                if (f != mini || s != minj)
                {
                    sum += arr1[f, s];

                }
                s++;
                if (s == arr1.GetLength(1))
                {
                    s = 0;
                    f++;
                }
            } while (f != maxi || s != maxj); // Why, || instead && I was doing it until 12am?
            Console.WriteLine($"The sum between min&max numbers is: {sum} ");


            //for (int i = mini; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        if (i > mini && j > minj)
            //        {
            //            sum += arr1[i, j];
            //            if (i == maxi && j == maxj)
            //            {
            //                break;
            //            }
            //        }

            //    }
            //}



                    Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task5 Визначити кількість елементів в заданому масиві, що відрізняються \r\nвід мінімального на 5.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {

                    Console.Write($"{arr1[i, j],4}");
                    if((min + 5) == arr1[i, j])
                    {
                        count++;
                    }
                    if((min -5) == arr1[i, j])
                    {
                        count++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"The number of the elements is: {count}");
        }
    }   
}
