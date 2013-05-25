using System;

namespace Exam.Generics
{
    static internal class GenericsTests
    {
        public static TU Downcast<TU, TT>(TT t) where TU : TT
        {
            return (TU)t;
        }

        public static void BasicTest()
        {
            var p = new Person();
            var z = Downcast<GoodPerson, Person>(p);
        }

        public static void GenericsClassTests()
        {
            A<int>.Value = 5;
            A<Int32>.Value = 10;
            A<uint>.Value = 15;
            A<UInt32>.Value = 20;
            A<double>.Value = 25;
            A<Double>.Value = 30;

            Console.WriteLine(A<int>.Value);
            Console.WriteLine(A<Int32>.Value);
            Console.WriteLine(A<uint>.Value);
            Console.WriteLine(A<UInt32>.Value);
            Console.WriteLine(A<double>.Value);
            Console.WriteLine(A<Double>.Value);
        }
    }

    internal class A<T>
    {
        public static int Value { get; set; }
    }
}