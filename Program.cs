using System;
using static InsideDotNet.DelegatesDemo;

namespace InsideDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsideDelegatesDemo();

            //InsideLambdaExpressions();

            //InsideFileHandlingDemo();

            //InsideReflectionDemo();

            //InsideCustomAttributes();

            //InsideSerializationDemo();

            InsideGenericCollectionsDemo();
        }

        private static void InsideGenericCollectionsDemo()
        {
            var attr = new GenericCollectionsDemo();
            attr.SortedListDemo();
        }

        private static void InsideSerializationDemo()
        {
            SerializationDemo ser = new SerializationDemo();
            var events = ser.DeserializeEvents();

            string eventsString = ser.SerializeEvents(events);
            Console.ReadKey();
        }

        private static void InsideCustomAttributes()
        {
            var attr = new CustomAttributesDemo();
            attr.CustomAttributesExample();
        }

        private static void InsideReflectionDemo()
        {
            ReflectionDemo refl = new ReflectionDemo();
            refl.ReflectionInvokeMethod();
        }

        private static void InsideFileHandlingDemo()
        {
            FileHandlingDemo fhd = new FileHandlingDemo();
            fhd.ReadingFile();
        }

        private static void InsideLambdaExpressions()
        {
            var lambda = new LambdaExpressionsDemo();
            lambda.LambdaOperationsOnUserDefinedClass();
        }

        private static void InsideDelegatesDemo()
        {
            var obj = new DelegatesDemo();
            addnum del_obj1 = new addnum(obj.Sum);
            subnum del_obj2 = new subnum(obj.Subtract);

            // pass the values to the methods by delegate object 
            del_obj1(100, 40);
            del_obj2(100, 60);

            // These can be written as using "Invoke" method 
            del_obj1.Invoke(100, 40);
            del_obj2.Invoke(100, 60);
        }
    }
}
