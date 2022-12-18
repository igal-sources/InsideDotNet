using System;

namespace InsideDotNet.InsideDemos
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

        #region Example: Invoke a Delegate && Passing Delegate as a Parameter

        public delegate void MyDelegate(string msg);

        public void InvokeDelegateSample()
        {
            //Example: Delegate
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            //Passing Delegate as a Parameter
            InvokeDelegate(del);

            del = ClassB.MethodB;
            del("Hello World");

            //Passing Delegate as a Parameter
            InvokeDelegate(del);
        }

        private void InvokeDelegate(MyDelegate del)
        {
            del("Hello World - Delegate as method Parameter");
        }

        #endregion

        #region Example: Generic Delegate

        public delegate T add<T>(T param1, T param2);

        public void GenericDelegateSample()
        {
            Console.WriteLine("Example of: Generic Delegate");
            Console.WriteLine("Call Generic Delegate with int");
            add<int> sum = SumGenerics;
            sum(5, 15);

            Console.WriteLine("Call Generic Delegate with string");
            add<string> con = ConcatGenerics;
            con("Hello", "World");
        }

        private int SumGenerics(int val1, int val2) 
        {
            Console.WriteLine($"Sum({val1} + {val2}) = {val1 + val2}");
            return val1 + val2;
        }

        public string ConcatGenerics(string str1, string str2)
        {
            Console.WriteLine($"Concat({str1} and {str2}) = {str1} {str2}");
            return $"{str1} {str2}";
        }

        #endregion

    }

    internal class ClassA
    {
        internal static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }
    internal class ClassB
    {
        internal static void MethodB(string message)
        {
            Console.WriteLine("Called ClassA.MethodB() with parameter: " + message);
        }
    }
}
