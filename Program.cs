using InsideDotNet.InsideDemos;
using System;
using static InsideDotNet.InsideDemos.DelegatesDemo;

namespace InsideDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadKey();
            }

            //InsideSingletonDemo();

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Delegates");
            Console.WriteLine("2) Lambda Expressions");
            Console.WriteLine("3) File Handling");
            Console.WriteLine("4) Reflection");
            Console.WriteLine("5) Custom Attributes");
            Console.WriteLine("6) Serialization");
            Console.WriteLine("7) Generic Collections");
            Console.WriteLine("8) Singleton");
            Console.WriteLine("9) Events");
            Console.WriteLine("10) Custom Attributes");
            Console.WriteLine("11) Asynchronous Task");
            Console.WriteLine("12) Overriding");
            Console.WriteLine("13) Generics");
            Console.WriteLine("14) JSON Demo");
            Console.WriteLine("999) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    InsideDelegatesDemo();
                    return true;
                case "2":
                    InsideLambdaExpressions();
                    return true;
                case "3":
                    InsideFileHandlingDemo();
                    return true;
                case "4":
                    InsideReflectionDemo();
                    return true;
                case "5":
                    InsideCustomAttributes();
                    return true;
                case "6":
                    InsideSerializationDemo();
                    return true;
                case "7":
                    InsideGenericCollectionsDemo();
                    return true;
                case "8":
                    InsideSingletonDemo();
                    return true;
                case "9":
                    InsideEventsDemo();
                    return true;
                case "10":
                    InsideCustomAttributes();
                    return true;
                case "11":
                    InsideAsynchronousTaskDemo();
                    return true;
                case "12":
                    InsideOverridingDemo();
                    return true;
                case "13":
                    InsideGenericsDemo();
                    return true;
                case "14":
                    InsideWorkingWithJsonsDemo();
                    return true;
                case "999":
                    return false;
                default:
                    return true;
            }
        }

        private static void InsideWorkingWithJsonsDemo()
        {
            var json = new JsonObjectsDemo();
            json.ConvertJsonToObject();
            json.ObjectToJSONStringConversion();
            json.ConvertJsonArrayToList();
            json.ObjectToJSONStringConversion();
        }

        private static void InsideGenericsDemo()
        {
            var generic = new GenericsDemo();
            generic.GenericClassMethods();
        }

        private static void InsideOverridingDemo()
        {
            var overr = new OverridingDemo();
            overr.SimpleOverriding();
        }

        private static async void InsideAsynchronousTaskDemo()
        {
            var taskDemo = new AsynchronousTaskDemo();
            taskDemo.RunMultipleTasks();
            taskDemo.RunTaskWithReturnValue();
            var t = await taskDemo.GetUrlContentLengthAsync();
            Console.WriteLine(t);

            await taskDemo.ExecuteAsyncFunctions();
        }

        private static void InsideSingletonDemo()
        {
            SingletonDemo.Instance.DoSingletonOperation();
        }

        private static void InsideGenericCollectionsDemo()
        {
            var attr = new GenericCollectionsDemo();
            attr.SortedListDemo();
        }

        private static void InsideEventsDemo()
        {
            var attr = new EventsDemo();
            attr.EventsExample();
        }

        private static void InsideSerializationDemo()
        {
            SerializationDemo ser = new SerializationDemo();
            var events = ser.DeserializeEvents();

            string eventsString = ser.SerializeEvents(events);            
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

            Console.WriteLine("DelegateSample" + Environment.NewLine);
            obj.InvokeDelegateSample();

            obj.GenericDelegateSample();
        }
    }
}
