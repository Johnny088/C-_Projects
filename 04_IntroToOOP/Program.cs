namespace _04_IntroToOOP
{
    class Freezer
    {
        private int volume;    // -10 min temperature // max 0 //width // height // brand //count
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value <= 0)

                {
                    value = 0;
                }
                else
                {
                    volume = value;
                }
            }

        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value < 45)
                {
                    width = 45;
                }
                else
                {
                    width = value;
                }
            }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set 
            {
                if (value < 80)
                {
                    height = 80;
                }
                else
                {
                    height = value;
                }
            }
        }

        private int release_date;

        public int Release_date
        {
            get { return release_date; }
            set 
            { 
                if(value < 2000 && value >=2025)
                {
                    release_date = 2000;
                }
                else
                {
                    release_date = value;
                }
                 
            }
        }
        public string Color { get; private set; }
        public Freezer()
        {
            
        }


    }
    internal class Program
    {



        static void Main(string[] args)
        {

        }
    }
}
