using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherAssembly;

namespace Exam
{
    class OtherClass : MyClass
    {
        public void Whatever()
        {
            DoSomething();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var m = new OtherClass();
            //m.Whatever();

            /*string a = "ab";
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
            */

            /*try
            {
                var a = 0;
                var x = 1 / a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/

            var p = new Person();
            var z = Downcast<GoodPerson, Person>(p);

            Console.ReadLine();
        }

        public static U Downcast<U, T>(T t) where U : T
        {
            return (U)t;
        }
    }

    class Person
    {
    }


    class GoodPerson : Person
    {
    }

    class E
    {
        A a1 = new A("a1");
        A a2 = new A("a2");
    }

    class F : E
    {
        A a3 = new A("a31");
        A a4 = new A("a41");

        public F()
            : this(5)
        {

        }

        private F(int i)
        {
            a4 = new A("a42");
        }
    }

    internal class A
    {
        public A(string s)
        {
            Console.WriteLine(s);
        }
    }
}
