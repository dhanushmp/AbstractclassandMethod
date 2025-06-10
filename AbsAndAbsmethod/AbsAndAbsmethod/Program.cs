namespace AbsAndAbsmethod
{

    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();

    }
    public class Rectangle:Figure
    {
        public Rectangle(double Width , double Height)
        {
            this.Width = Width;
            this.Height = Height;   
        }
        public override double GetArea()
        {
            return Width * Height;
        }

    }
    public class Circle:Figure   
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Cone: Figure
    {
        public Cone(double Radius , double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius + Pi * Radius * Math.Sqrt((Radius * Radius) + (Height * Height));
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Circle circle = new Circle(7);
            Cone cone = new Cone(3, 4);

            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");
            Console.WriteLine($"Area of Cone: {cone.GetArea()}");
        }
    }
}
