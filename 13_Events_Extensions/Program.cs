
using System.Globalization;



namespace _13_Events_Extensions
{
    class Trader
    {
        CultureInfo myCIintl = new CultureInfo("en-US", false);
        public string Name { get; set; }
        public string Surname { get; set; }
        public double CurrencyUSD { get; set; }
        public double CurrencyUAH { get; set; }
        public Trader() { Name = "No Name"; Surname = "No Surname"; }
        public Trader(string name, string surname) { Name = name; Surname = surname; }
        public void deal(double rate)
        {
            if (rate > 42)
            {
                Console.WriteLine($"I'm {Name}, and I'm buying {300.ToString("C2", myCIintl)}");
            }
            if (rate <=42)
            {
                Console.WriteLine($"I'm {Name}, and I'm selling {300.ToString("C2", myCIintl)}");
            }
        }

    }
    public delegate void DealDelegate(double rate);
    class CurrencyExchange
    {
        public event DealDelegate DealDelegate;
        public double CurrentRate { get; set; }
        public void GenerateRate()
        {
            CurrentRate = new Random().NextDouble() +new Random().Next(35,45);
            DealDelegate?.Invoke(CurrentRate);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Trader trader = new Trader();
            Trader[] traders = new Trader[] { 
            new Trader{
             Name = "Johnny",Surname = "Depp", CurrencyUSD = 50000, CurrencyUAH = 20000},
            new Trader
            {Name = "Oleg", Surname = "Forgot", CurrencyUSD = 50000, CurrencyUAH = 20000 },
            new Trader{Name = "Sofia", Surname = "Surname", CurrencyUSD = 50000, CurrencyUAH = 20000 }
            };
            CurrencyExchange exchange = new CurrencyExchange();

            foreach(var person in traders)
            {
                exchange.DealDelegate += person.deal;
               
            }
            //traders.deal(30);
            //traders.deal(43);
            Console.WriteLine("---------------1------------------");
            exchange.GenerateRate();
            Console.WriteLine("----------------2-----------------");
            exchange.GenerateRate();
            Console.WriteLine("----------------3-----------------");
            exchange.GenerateRate();

        }
    }
}
