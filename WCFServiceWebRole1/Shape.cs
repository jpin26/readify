using knockknock.readify.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceWebRole1
{
    public static class Shape
    {
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            var ab = a == b;
            var ac = a == c;
            var bc = b == c;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }            

            if (ab && ac && bc)
            {
                return TriangleType.Equilateral;
            }

            if (ab)
            {
                return a + b <= c ? TriangleType.Error : TriangleType.Isosceles;
            }

            if (ac)
            {
                return a + c <= b ? TriangleType.Error : TriangleType.Isosceles;
            }

            if (bc)
            {
                return b + c <= a ? TriangleType.Error : TriangleType.Isosceles;
            }

            if (a > b && a > c && b + c <= a)
            {
                return TriangleType.Error;
            }

            if (b > a && b > c && a + c <= b)
            {
                return TriangleType.Error;
            }

            return a + b <= c ? TriangleType.Error : TriangleType.Scalene;
        }
    }
}