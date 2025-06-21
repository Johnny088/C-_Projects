namespace _001_test
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char[,] board= new char[9,9];
            for (int i = 0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    
                    Console.Write('\uFA09');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            char WhiteHorse = '\u265E';
            char BlackKing = '\u2654';
            char WhiteKing = '\u265A';
            Console.WriteLine(WhiteHorse + " ");
            Console.WriteLine(BlackKing);
            Console.WriteLine(WhiteKing);
            
        }
    }
}
