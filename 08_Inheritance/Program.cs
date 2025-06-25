
namespace _08_Inheritance
{

    abstract class GeometricShape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }

        public abstract void GetArea();
        public abstract void GetPerimeter();


    }
    class Triangle : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Square : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Rhombus : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Parallelogram : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Trapezoid : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Circle : GeometricShape
    {
        public override void GetArea()
        {
            throw new NotImplementedException();
        }

        public override void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
