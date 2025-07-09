
namespace _08_Inheritance
{

    abstract class GeometricShape
    {
        
        //private int a;

        //public int A
        //{
        //    get { return a; }
        //    set {
        //        if (value < 1)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            throw new Exception("the number can't be 0 or less");
        //        }
        //        else
        //            a = value;
        //    }
        //}
        //private int b;
        //public int B
        //{
        //    get { return b; }
        //    set
        //    {
        //        if (value < 1)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            throw new Exception("the number can't be 0 or less");
        //        }
        //        else
        //            b = value;
        //    }
        //}
        //private int h;
        //public int H
        //{
        //    get { return h; }
        //    set
        //    {
        //        if (value < 1)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            throw new Exception("the number can't be 0 or less");
        //        }
        //        else
        //            h = value;
        //    }
        //}
        //protected GeometricShape(int a, int b, int h) { A = a; B = b; H = h; }


        public abstract void GetArea();
        public abstract void GetPerimeter();


    }
    class Triangle : GeometricShape          //area = 1/2 * b * h ------- P = a + b + c
    {
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double c;
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                    c = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        


        public Triangle(double a, double b, double c, double h){ A = a; B = b; C = c; H = h; } 
        public override void GetArea()
        {

            Console.WriteLine($"The area of the triangle = {0.5 * b * h}");         // b is the base of the triangle --- and --- h is the height dropped onto side b 
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the triangle = {a+b+c}");
        }
    }

    class Square : GeometricShape                               // Perimeter = 4 * a           ------  S = a * a 
    {
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Square(double a){ A = a; }

        public override void GetArea()
        {
            Console.WriteLine($"The area of the square = {a * a}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"THe perimeter of the square = {4*a}");
        }
    }

    class Rhombus : GeometricShape                     // p = 4 * a      area = a * h
    {
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double h;

        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Rhombus(double a, double h) { A = a; H = h; }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the rhombus = {a * h}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the rhombus = {4 * a}");
        }
    }

    class Rectangle : GeometricShape                     // p = 2 * (a + b) ------------- Area = a * b
    {
        private double a;
        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Rectangle(double a, double b) { A = a; B = b; }
        public override void GetArea()
        {
            Console.WriteLine($"the area of the rectangle = {a * b }");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"the perimeter of the rectangle = {2 * (a + b)}");
        }
    }

    class Parallelogram : GeometricShape                 // p = 2 * (a + b)   ------------ Area = a * h
    {
        private double a;
        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Parallelogram(double a, double b, double h) { A = a; B = b; H = h; }

        public override void GetArea()
        {
            Console.WriteLine($"The area of the parallelogram = {a * h}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the parallelogram = {2 * (a + b)}");
        }
    }
    class Trapezoid : GeometricShape                       // P = a + b + c + d   ================== Area = 1/2 * (a + b) * h  (a and b are parallel basses) 
    {
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double c;
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                    c = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double d;
        public double D
        {
            get { return d; }
            set
            {
                if (value > 0)
                    d = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Trapezoid(double a, double b, double c, double d, double h) { A = a; B = b; C = c; D = d; H = h; }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the trapezoid = {0.5 * (a + b ) * h }");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the trapezoid = {a + b + c + d}");
        }
    }
    class Circle : GeometricShape                           // P = 2pr   Area = p(r*r)
    {
        private const double pi = 3.14;
        private double r;

        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("the number can't be 0 or less");
                }
            }
        }
        public Circle(double r) { R = r; }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the circle is = {pi * (r*r)}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"THe perimeter of the circle = {2 * pi * r}");
        }
    }
    class CompositeShape
    {
        GeometricShape[] shapes;
        public CompositeShape(params GeometricShape[] shape)
        {
            shapes = shape;
        }
        public void AddShape(GeometricShape shape)
        {
            Array.Resize(ref shapes, shapes.Length + 1);
            shapes[shapes.Length - 1] = shape;
        }
        public void PrintResult()
        {
            foreach (GeometricShape shape in shapes)
            {
                Console.WriteLine("-------------------------------------------");
                shape.GetArea();
                shape.GetPerimeter();
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Triangle \n\tTriangle(10,5,8,7);");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("area = 1 / 2 * b * h ------- P = a + b + c");
            Triangle tr1 = new  Triangle(10,5,8,7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            tr1.GetArea();
            tr1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Square \n\tSquare(5)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Perimeter = 4 * a  ------  Area = a * a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Square sc1 = new Square(5);
            sc1.GetArea();
            sc1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rhombus \n\tRhombus(5,7)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("p = 4 * a ----- area = a * h");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Rhombus rh1 = new Rhombus(5,7);
            rh1.GetArea();
            rh1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("rectangle \n\trectangle(5,10)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("p = 2 * (a + b) ------------- Area = a * b");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Rectangle rec1 = new Rectangle(5,10);
            rec1.GetArea();
            rec1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("parallelogram \n\tParallelogram(5,10,7)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("p = 2 * (a + b)   ------------ Area = a * h");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Parallelogram par1 = new Parallelogram(5,10,7);
            par1.GetArea();
            par1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Trapezoid \n\ttrapezoid(5,20,7, 15, 6)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("P = a + b + c + d   ================== Area = 1/2 * (a + b) * h  (a and b are parallel basses) ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Trapezoid trap1 = new Trapezoid(5,20,7,15,6);
            trap1.GetArea();
            trap1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Circle \n\tCircle(5)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("P = 2pr   Area = p(r*r)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Circle c1 = new Circle(5);
            c1.GetArea();
            c1.GetPerimeter();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //GeometricShape[] shapes = new GeometricShape[]
            //{
            //    tr1,
            //    rh1,
            //    rec1,
            //    par1,
            //    trap1,
            //    c1
            //};
            //CompositeShape figures = new CompositeShape(shapes);
            CompositeShape figures = new CompositeShape(tr1,rh1,rec1,par1,trap1,c1);
            figures.PrintResult();

            Console.ResetColor();
        }
    }
}
