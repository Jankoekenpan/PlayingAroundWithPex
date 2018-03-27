using System;
using System.Diagnostics.Contracts;

namespace ConsoleApp2
{

    public class Foo
    {
        public bool MyMethod(bool p, bool q, bool r)
        {
            if (!p)
            {
                if (q || r)
                {
                    q = !r;
                }
                else
                {
                    q = !q;
                }
            }

            return q;
        }
    }

    public class Bar
    {
        public int stringLength(string s)
        {
            return s.Length;
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
            if (x <= 0 || y <= 0 || z <= 0) return TriangleType.NONPOSITIVE_INPUT;
            if (x + y < z || z + x < y || y + z < x) return TriangleType.TRIANGLE_INEQUALITY;
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
        NONPOSITIVE_INPUT,
        TRIANGLE_INEQUALITY,
    }

    public class InterfaceConsumer
    {
        public string DoSomethingWithMyInterface(MockMe mockMe)
        {
            return mockMe.GetString() + mockMe.GetInteger().ToString();
        }
    }

    public interface MockMe
    {
        string GetString();

        int GetInteger();
    }


    public class CodeContractExample
    {
        public int divide(int teller, int noemer)
        {
            Contract.Requires(noemer != 0);
            return teller / noemer;
        }
    }

    public class WeekendNotifier
    {
        public bool IsWeekendNear()
        {
            DateTime date = DateTime.Now;
            date.AddDays(2);
            if (date.Day.Equals("Saturday"))
            {
                return true;
            }
            return false;
        }
    }

}
