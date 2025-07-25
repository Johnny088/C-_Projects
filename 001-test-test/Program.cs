namespace _001_test_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(" directory: \t{0}", dir.FullName);
            Console.WriteLine(" Creation time: \t{0}", dir.CreationTime);
            Console.WriteLine(" Extension: \t{0}", dir.Extension);
            Console.WriteLine(" LastAccessTime: \t{0}", dir.LastAccessTime);
            Console.WriteLine(" LastWriteTime: \t{0}", dir.LastWriteTime);
            Console.WriteLine(" Name: \t{0}", dir.Name);
            dir.GetDirectories(); // shows nothing in this case
            dir.GetFiles();       // the same
            // the right way to use it
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------------Directories-----------------------------------------");
            foreach (var d in dir.GetDirectories())
            {
                Console.WriteLine($"Directory: {d.Name,25} \ttime: {d.CreationTime,25} \tatr: {d.Attributes,25}");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var d in dir.GetFiles())
            {
                Console.WriteLine($"Directory: {d.Name,40} \ttime: {d.CreationTime,30} \tatr: {d.Attributes,25}");
            }
            Console.ResetColor();
            Console.Write(path + @"\");
            string next = Console.ReadLine()!;
            string nextPath = Path.Combine(path,next);
            DirectoryInfo dirr = new DirectoryInfo(@"f:\TestToday");
            if (!dirr.Exists)
            {
                dirr.Create();
            }

            //Console.WriteLine("1 - delete \n2 - Rename \n3 - Create \n4 - Open");

        }
    }
}
