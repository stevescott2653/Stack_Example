using System;
using System.Collections.Generic;


namespace Stack_Example
{
    public class StackExample
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("John");
            names.Push("Bob");
            names.Push("Tom");
            names.Push("Chris");
            names.Push("Albert");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
        }
    }
}