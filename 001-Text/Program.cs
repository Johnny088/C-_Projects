namespace _001_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][]arr = [new int[8], new int[3], new int[4]];
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = new Random().Next(20);
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach(int[] j  in arr)
            {
                foreach (int k in j)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine() ;
            }
        }
        
    }
}
