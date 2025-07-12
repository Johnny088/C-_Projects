
using System.Collections;
namespace _10_StandartInterface
{
    enum Genre {Horror, Comedy, Action, Fantastic}
    class Director : ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{"Director:",-20}{Name} {Surname} \n";   
        }
        //public Director(string name, string surname)
        //{
        //    Name = name;
        //    Surname = surname;
        //}
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Movie: IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Director director;
        public string Country { get; set; }
        public Genre genre;
        private DateTime datetime;

        public DateTime Datetime
        {
            get { return datetime; }
            set 
            {
               datetime = value <= DateTime.Now ? value : DateTime.Now;
            }
        }
        private float rating;


        public float Rating
        {
            get { return rating; }
            set 
            { 
               if(value > 0 && value <= 5)
                    rating = value;
               else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Given rating isn't correct");
                }
                    
            }
        }
        public override string ToString()
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            return director.ToString() + $"{"Name:", -20}{Name} \n{"Description:", -20}{Description} \n{"Country:", -20}{Country} \n{"Genre:", -20}{genre} \n{"Datetime", -20}{datetime.ToShortDateString()} \n{"Rating:", -20}{rating} \n------------------------------------------------------------------------------------------------ ";
        }

        
        //public int CompareTo(object? obj)      // this option given after we include it by auto property
        //{
        //    return Name.CompareTo(obj);
        //}

        public int CompareTo(object? obj)
        {
            return Name.CompareTo((obj as Movie)!.Name);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Cinema: IEnumerable
    {
        private Movie[] movies;

        public void Sort()
        {
            Array.Sort(movies);
        }
        public Cinema()
        {
            movies = [
            new Movie
            {
                Name = "The fifth Element",
                Description = "Really cool movie",
                director = new Director {Name = "Luc", Surname = "Besson"},
                Country = "The USA",
                genre = Genre.Action,
                Datetime = new DateTime(1997, 05, 09),
                Rating = 5,
            },
            new Movie
            {
                Name = "The Matrix",
                Description = "A mind-bending sci-fi film about a hacker who discovers that reality is a simulation controlled by machines.",
                director = new Director {Name = "Lana", Surname = "Wachowski"},
                Country = "The USA",
                genre = Genre.Action,
                Datetime = new DateTime(1999, 03, 31),
                Rating = 5,
            },
            new Movie
            {
                Name = "Johnny Mnemonic",
                Description = "In a cyberpunk future a data courier must deliver sensitive information stored in his brain before time runs out",
                director = new Director {Name = "Robert", Surname = "Longo"},
                Country = "The USA",
                genre = Genre.Action,
                Datetime = new DateTime(1995, 05, 26),
                Rating = 3.5f,
            },
            new Movie
            {
                Name = "Fight club",
                Description = "A disillusioned man forms an underground fight club with a mysterious soap salesman leading to chaos and self-discovery.",
                director = new Director {Name = "David", Surname = "Fincher"},
                Country = "The USA",
                genre = Genre.Action,
                Datetime = new DateTime(1999, 10, 15),
                Rating = 5,
            },
            new Movie
            {
                Name = "Minority report",
                Description = "In future where crimes are prevented before they occur, a top cop is accused of a murder he hasn't committed yet.",
                director = new Director {Name = "Steven", Surname = "Spielberg"},
                Country = "The USA",
                genre = Genre.Fantastic,
                Datetime = new DateTime(2002, 06, 21),
                Rating = 4.5f,
            },
            new Movie
            {
                Name = "Edge of Tomorrow",
                Description = "A soldier caught in a time loop relieves the same battle against alien invaders, becoming stronger with each repetition.",
                director = new Director {Name = "Doug", Surname = "Liman"},
                Country = "The USA",
                genre = Genre.Fantastic,
                Datetime = new DateTime(2014, 06, 06),
                Rating = 4.6f,
            },
            new Movie
            {
                Name = "Interstellar",
                Description = "A team of explorers travels through a wormhole in space in an attempt to save humanity from a dying Earth.",
                director = new Director {Name = "Christopher", Surname = "Nolan"},
                Country = "The USA",
                genre = Genre.Fantastic,
                Datetime = new DateTime(2014, 11, 07),
                Rating = 5,
            }
            ];
        }
        

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }
    }
    #region Icomparer
    class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    class CompareByDirector : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.director.Surname.CompareTo(y.director.Surname);
        }
    }
    class CompareDate : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Datetime.CompareTo(y.Datetime);
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sort by name by using ICompareble-----------------------------------------------------------");
            cinema.Sort();
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Sort by Director's Surname by using Icomparer-----------------------------------------------------------");
            cinema.Sort(new CompareByDirector());
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Sort by Rating by using Icomparer-----------------------------------------------------------");
            cinema.Sort(new CompareByRating());
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Sort by Date by using Icomparer-----------------------------------------------------------");
            cinema.Sort(new CompareDate());
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Test ICloneable-----------------------------------------------------------");
            Movie origin = new Movie() 
            {
                Name = "The fifth Element",
                Description = "Really cool movie",
                director = new Director { Name = "Luc", Surname = "Besson" },
                Country = "The USA",
                genre = Genre.Action,
                Datetime = new DateTime(1997, 05, 09),
                Rating = 5,

            };
            Console.WriteLine("---------------------------Test ICloneable origin-----------------------------------------------------------");
            Console.WriteLine(origin);
            Movie copy = (origin.Clone()as Movie)!;
            copy.director.Name = "New name";
            copy.Rating = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Test ICloneable Copy-----------------------------------------------------------");
            Console.WriteLine(copy);
        }
    }
}
