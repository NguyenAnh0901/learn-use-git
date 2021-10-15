using System;
using System.Linq;
using System.Collections.Generic;

namespace learn_use_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 20;
            string name = "Anh";
            Console.WriteLine($"{name} is {age} years old");
            IList<int> numbers = new List<int>();
            foreach (var number in Enumerable.Range(1, 10)) numbers.Add(number);
            var r = numbers.Where(x => x % 2 == 0);
            foreach (var x in r) Console.WriteLine(x);
            Console.WriteLine("Make from first branch");
        }
    }
}
