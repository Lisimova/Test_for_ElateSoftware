using System;

namespace Test_for_ElateSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack<int>();
            Console.WriteLine(s.IsEmpty());
            s.Push(10);
            s.Push(20);
            Console.WriteLine(s);
            Console.WriteLine(s.IsEmpty());
            Console.WriteLine("On the Top was " + s.Pop());
            Console.WriteLine("On the Top was " + s.Pop());
            Console.WriteLine(s);
            Console.WriteLine(s.IsEmpty());
            Console.ReadKey();
        }
    }
}
