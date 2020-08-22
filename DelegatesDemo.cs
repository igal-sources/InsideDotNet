using System;

namespace InsideDotNet
{
    internal class DelegatesDemo
    {
        // Declaring the delegates 
        // Here return type and parameter type should  
        // be same as the return type and parameter type 
        // of the two methods 
        // "addnum" and "subnum" are two delegate names 
        internal delegate void addnum(int a, int b);
        internal delegate void subnum(int a, int b);

        public void Sum(int a, int b)
        {
            Console.WriteLine($"({a} + {b}) = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"({a} - {b}) = {a - b}");
        }
    }
}
