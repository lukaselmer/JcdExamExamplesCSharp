using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherAssembly
{
    public class MyClass
    {
        protected internal void DoSomething()
        {
            Console.WriteLine("test");
        }
    }

    public class XxxClass
    {
        protected void DoSomething()
        {
            var x = new MyClass();
            x.DoSomething();
        }
    }
}
