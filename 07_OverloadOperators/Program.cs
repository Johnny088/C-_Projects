using _07_OverloadOperators;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace _07_OverloadOperators
{
    class Square
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Your side must be more than 0");
                }
                else
                {
                    sideA = value;
                }
            }
        }
        public Square()
        {
            SideA = 1;
        }
        public Square(int value)
        {
            SideA = value;
        }
        public override string ToString()
        {
            return $"A = {SideA} \n";
        }


        public static Square operator ++(Square point)
        {
            point.SideA++;
            return point;
        }
        // a= a+1
        public static Square operator --(Square point)
        {
            
            point.SideA++;
            return point;
        }
        
    }


    // //////////////////////////////////////////////////////////////////////////////////////////////////////

    class Rectangle
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Your side must be more than 0");
                }
                else
                {
                    sideA = value;
                }
            }
        }
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Your side must be more than 0");
                }
                else
                {
                    sideB = value;
                }
            }
        }
        public Rectangle()
        {
            SideA = 1;
            SideB = 1;
        }
        public Rectangle(int a, int b)
        {
            SideA = a;
            SideB = b;
        }
        public override string ToString()
        {
            return $"A = {SideA} \t B = {SideB} \n";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Square first = new Square(-1);
            }
            catch (Exception e) { Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(e.Message); Console.ResetColor(); }
            Square test2 = new Square(4);
            Console.WriteLine(test2);
            Console.WriteLine("------------Rectangle------------");
            Rectangle test3 = new Rectangle(4, 8);
            Console.WriteLine(test3);

        }
    }
}
