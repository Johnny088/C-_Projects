using _07_OverloadOperators;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace _07_OverloadOperators
{
    class Square
    {
        private int sideA;

        public int SideA
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

        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   SideA == square.SideA;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SideA);
        }

        #region Operators ++/--
        public static Square operator ++(Square point)
        {
            point.SideA++;
            return point;
        }
        // a= a+1
        public static Square operator --(Square point)
        {

            point.SideA--;
            return point;
        }
        #endregion
        #region Operators + - * /
        public static Square operator -(Square value1, Square value2)
        {
            Square res = new Square
            {
                SideA = value1.SideA - value2.SideA
            };
            return res;
        }
        public static Square operator +(Square value1, Square value2)
        {
            Square res = new Square
            {
                SideA = value1.SideA + value2.SideA

            };
            return res;
        }
        public static Square operator *(Square value1, Square value2)
        {
            Square res = new Square
            {
                SideA = value1.SideA * value2.SideA
            };
            return res;
        }
        public static Square operator /(Square value1, Square value2)
        {
            //return new Square { value1.SideA / value2.SideA };
            Square res = new Square { SideA = value1.SideA / value2.SideA };
            return res;
        }
        #endregion


        #region Logic Operators <> <= => == !=
        public static bool operator ==(Square value1, Square value2)
        {
            return value1.Equals(value2);
        }
        public static bool operator !=(Square value1, Square value2)
        {
            return value1.Equals(value2);
        }
        public static bool operator <(Square value1, Square value2)
        {
            return value1.SideA < value2.SideA;
        }
        public static bool operator >(Square value1, Square value2)
        {
            return value1.SideA > value2.SideA;
        }
        public static bool operator <=(Square value1, Square value2)
        {
            return value1.SideA <= value2.SideA;
        }
        public static bool operator >=(Square value1, Square value2)
        {
            return value1.SideA >= value2.SideA;
        }

        #endregion
        #region True False operators
        public static bool operator true(Square a)
        {
            return a.SideA > 0;
        } 
        public static bool operator false(Square a)
        { 
                return a.SideA < 1;   
        }
        #endregion


        #region overload types
        public static implicit operator Rectangle(Square s1)
        {
            return new Rectangle  (s1.SideA, s1.SideA+10);
        }
        public static implicit operator int(Square s1)
        {
            return s1.SideA;
        }

        #endregion
    }


    // //////////////////////////////////////////////////////////////////////////////////////////////////////

    class Rectangle
    {
        private int sideA;

        public int SideA
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
        private int sideB;

        public int SideB
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

        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   SideA == rectangle.SideA &&
                   SideB == rectangle.SideB;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SideA, SideB);
        }
        #region operators ++ --
        public static Rectangle operator ++(Rectangle r)
        {
            r.SideA++;
            r.SideB++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.SideA--;
            r.SideB--;
            return r;
        }



        #endregion

        #region Operators + - * /
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA + r2.SideA,
                SideB = r1.SideB + r2.SideB,
            };
            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA - r2.SideA,
                SideB = r1.SideB - r2.SideB,
            };
            return res;
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA * r2.SideA,
                SideB = r1.SideB * r2.SideB,
            };
            return res;
        }

        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA / r2.SideA,
                SideB = r1.SideB / r2.SideB,
            };
            return res;
        }
        #endregion

        #region operators < > <= >=
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) < (r2.SideA + r2.SideB);
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) > (r2.SideA + r2.SideB);
        }

        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) <= (r2.SideA + r2.SideB);
        }

        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) >= (r2.SideA + r2.SideB);
        }
        #endregion

        #region Operator == !=
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) == (r2.SideA + r2.SideB);
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) != (r2.SideA + r2.SideB);
        }
        #endregion


        #region Overload to Square
        public static explicit operator Square(Rectangle r)
        {
            return new Square(r.SideA + r.SideB);
        }
        public static explicit operator int(Rectangle r)
        {
            return r.SideA + r.SideB;
        }
        #endregion
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(test2);
            Console.WriteLine("------------Rectangle------------");
            Rectangle test3 = new Rectangle(4, 8);
            Console.WriteLine(test3);
            try 
            {
                Square a1 = new Square(4);
                Square a2 = new Square(4);
                if (a1 == a2)
                {
                    Console.WriteLine("The Squares are equal ");
                }
                else { Console.WriteLine("The aren't equal "); }
            }
            catch (Exception e) { Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(e.Message); Console.ResetColor(); }
            Square a3 = new Square(4);
            Square a4 = new Square(7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("first square = 4, the second = 7");
            Console.WriteLine("-------------------- > -------------------");
            Console.WriteLine(a3>a4);
            Console.WriteLine("-------------------- < -------------------");
            Console.WriteLine(a3<a4);
            Console.WriteLine("-------------------- <= -------------------");
            Console.WriteLine(a3<=a4);
            Console.WriteLine("-------------------- >= -------------------");
            Console.WriteLine(a3>=a4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------True / False-------------------");
            if (a3)
            { Console.WriteLine("true"); }
            else 
            { Console.WriteLine("false"); }

            Rectangle rec1 = new Rectangle(2,3);
            Rectangle rec2 = new Rectangle(3,2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rectangle(2,3) == Rectangle(3,2) ");
            Console.WriteLine("-------------------- == -------------------");
            if (rec1 == rec2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("-------------------- != -------------------");
            if (rec1 != rec2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Square s1 = new Square();
            Square s2 = new Square(20);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------- Explicit from Rectangle to Square  -------------------");
            s1 = (Square)rec1;
            int value;
            Console.WriteLine(s1);
            Console.WriteLine("-------------------- Explicit from Rectangle to int  -------------------");
            value = (int)rec2;
            Console.WriteLine(value);
            Console.WriteLine("-------------------- Implicit from Square to int  -------------------");
            value = s2;
            Console.WriteLine(value);
            Console.WriteLine("-------------------- Implicit from Square to Rectangle  -------------------");
            Rectangle rec3 = s2;
            Console.WriteLine(rec3);
            Console.ResetColor ();
        }
    }
}
