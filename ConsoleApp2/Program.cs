using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new HelloWorld().GetHelloWorld());
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }
    }

    public class Foo
    {
        public String Bar(int lol)
        {
            return new HelloWorld().GetHelloWorld();
        }
    }

    public class Bar
    {
        public String Foo(Foo iksDee)
        {
            return iksDee.Bar(0);
        }
    }

    public class HelloWorld
    {
        public virtual String GetHelloWorld()
        {
            return "Hello, World!";
        }
    }


    public class Triangle
    {
        public readonly int x, y, z;

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        
        public TriangleType getTriangleType()
        {
            if (x <= 0 || y <= 0 || z <= 0) return TriangleType.INVALID;
            if (x + y < z || z + x < y || y + z < x) return TriangleType.INVALID;
            if (x == y && y == z) return TriangleType.EQUILITERAL;
            if (x == y || y == z || z == x) return TriangleType.ISOSCELES;

            return TriangleType.SCALENE;
        }
    }

    public enum TriangleType
    {
        SCALENE,
        ISOSCELES,
        EQUILITERAL,
        INVALID,
    }

}
