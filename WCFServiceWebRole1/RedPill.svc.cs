using knockknock.readify.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return new Guid("62f525b3-f395-4813-8831-7a2af98747c2");
        }

        public long FibonacciNumber(long n)
        {
            return Fibonacci.ValueAt(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return Shape.GetTriangleType(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return ReverseWord.Reverse(s);
        }

    }
}
