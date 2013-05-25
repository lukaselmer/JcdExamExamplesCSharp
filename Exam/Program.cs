using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Generics;
using Exam.ObjectConstruction;
using Exam.OverloadingAndOverriding;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OtherClassTest();
            StringTests();
            DivisionByZeroTests();
            GenericsTests.BasicTest();
            OverrideOverloadTests();*/

            GenericsTests.GenericsClassTests();

            HashTests.Tests.DoIt();

            Console.ReadLine();
        }

        private static void OverrideOverloadTests()
        {
            A a = new A(), b = new B(), c = new C();
            I ia = new A(), ib = new B(), ic = new C();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", a.P, b.P, c.P, ia.P, ib.P, ic.P);
        }

        private static void DivisionByZeroTests()
        {
            try
            {
                var a = 0;
                var x = 1/a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void StringTests()
        {
            string a = "ab";
            string b = "a";
            string c = b;
            b += "b";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.Write(a == b);
            Console.Write(' ');
            Console.Write(b == c);
            Console.Write(' ');
            Console.Write(a.Equals(b));
            Console.Write(' ');
            Console.Write(a.Equals(c));
        }

        private static void OtherClassTest()
        {
            var m = new OtherClass();
            m.Whatever();
        }
    }
    
}
