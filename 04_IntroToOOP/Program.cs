namespace _04_IntroToOOP
{
    partial class Freezer
    {
        
        
        public void print()
        {
            Console.WriteLine($"Volume: {volume} \nWidth: {width} \nHeight: {height} \nRelease date: {release_date} \nColor {Color} \nBrand: {brand} \nTotal number of freezers: {count} \n-------------------");
        }
        static Freezer()
            {
                brand = "Bliss";
                count = 0;
                count++;

            }
        public Freezer()
        {
            Volume = volume;
            Width = width;
            Height = height;
            Release_date = release_date;
        }
        public Freezer(int volume, int width, int height, int release_date, string color)
        {
            Volume = volume;
            Width = width;
            Height = height;
            Release_date = release_date;
            Color = color;
        }
        public override string ToString()
        {
            return $"Volume: {volume} \nWidth: {width} \nHeight: {height} \nRelease date: {release_date} \nColor {Color} \nBrand: {brand} \nTotal number of freezers: {count} \n-------------------"; 
        }

    }
    internal class Program
    {



        static void Main(string[] args)
        {
            Freezer f = new Freezer();
            f.print();
            Freezer[] freezers = new Freezer[5];
            Console.WriteLine("-------------------------Array---------------------------");
            for (int i = 0; i < freezers.Length; i++)
            {
                freezers[i] = new Freezer();
            }
            for (int i = 0;i < freezers.Length;i++)
            {
                freezers[i].print();
            }
            Console.WriteLine("-----------------------------Parametrized constructor----------------------------");
            Freezer freezer = new Freezer(60, 80, 100, 2022, "Red");
            freezer.print();
            Console.WriteLine("--------------------------------Override---------------------------------------");
            Console.WriteLine(freezer);
        }
    }
}
