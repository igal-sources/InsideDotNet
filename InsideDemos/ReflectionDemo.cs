using System;
using System.Reflection;

namespace InsideDotNet.InsideDemos
{
    public class ReflectionDemo
    {
        public void ReflectionInvokeMethod()
        {
            string dllFullName = "InsideDotNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            Assembly a = Assembly.Load(dllFullName);

            // Get the type to use.
            Type myType = a.GetType("InsideDotNet.DataContracts.AssemblyClassDemo");

            // Get the method to call.
            MethodInfo myMethod = myType.GetMethod("DisplayVariables");

            // Create an instance. 
            object obj = Activator.CreateInstance(myType);

            // Execute the method.
            myMethod.Invoke(obj, null);
        }

        public void DoReflectionOnClass()
        {
            Type demoClass = Type.GetType("InsideDotNet.DataContracts.AssemblyClassDemo");
            MethodInfo[] methodInfos = demoClass.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Methods of current type is: \n");
            for (int i = 0; i < methodInfos.Length; i++)
            {
                Console.WriteLine(" {0}", methodInfos[i]);
            }

            Console.WriteLine("\n");

            PropertyInfo[] properties = demoClass.GetProperties();
            
            Console.WriteLine("Properties of current type is:  \n");
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(" {0}", properties[i]);
            }
        }

        public void DoReflection()
        {
            // Declare Instance of class Assembly 
            // Call the GetExecutingAssembly method to load the current assembly 
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly 
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type 
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods 
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters 
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter 
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}
