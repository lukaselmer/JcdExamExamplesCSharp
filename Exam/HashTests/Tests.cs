using System;
using System.Collections.Generic;

namespace Exam.HashTests
{
    internal class Tests
    {
        public static void DoIt()
        {
            var myMap = new Dictionary<MyKey, string>();
            var key = new MyKey("A");
            myMap.Add(key, "v1");

            key = new MyKey("B");
            myMap.Add(key, "v2");
            myMap[key] = "v3";

            key = new MyKey("A");
            myMap[key] = "v3";

            myMap.Remove(new MyKey("B"));

            Console.WriteLine("size: {0}", myMap.Count);
        }
    }

    internal class MyKey
    {
        private readonly string _code;

        public MyKey(string code)
        {
            _code = code;
        }

        public override int GetHashCode()
        {
            return _code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is MyKey)) return false;

            return _code == ((MyKey)obj)._code;
        }
    }
}