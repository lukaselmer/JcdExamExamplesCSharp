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
        //given
        internal class CData
        {
            public int Id;
            public string Name;
        }

        // given
        internal class OrderInDescId
        {
            public static bool IsLessThen(CData o, CData o1)
            {
                return o.Id < o1.Id;
            }
        }

        // given
        internal class OrderInAlphName
        {
            public static bool IsLessThen(CData o, CData o1)
            {
                return String.CompareOrdinal(o.Name, o1.Name) != 0;
            }
        }

        //given
        private static void Quicksort(CData[] arr, SortingCreterion sortingCreterion)
        {
            Array.Sort(arr, (a, b) => sortingCreterion(a, b) ? -1 : 1);
        }


        private delegate bool SortingCreterion(CData a, CData b);


        static void Main(string[] args)
        {
            var b = new Extended();
            var b2 = new Extended();

            /*SortingCreterion s1 = OrderInDescId.IsLessThen;
            SortingCreterion s2 = OrderInAlphName.IsLessThen;

            var arr = new CData[33];
            Quicksort(arr, s1);
            Quicksort(arr, s2);*/

            /*OtherClassTest();
            StringTests();
            DivisionByZeroTests();
            GenericsTests.BasicTest();
            OverrideOverloadTests();*/

            //GenericsTests.GenericsClassTests();

            //HashTests.Tests.DoIt();

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
                var x = 1 / a;
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

    internal class Extended : Base
    {
        private static Print p1 = new Print("ext1");
        static Extended()
        {
            new Print("ext2");
        }
    }

    internal class Base
    {
        static Base()
        {
            new Print("b2");
        }
        private static Print p1 = new Print("b1");
    }

    internal class Print
    {
        public Print(string p1)
        {
            Console.WriteLine(p1);
        }
    }
}
