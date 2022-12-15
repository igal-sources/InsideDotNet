using System;
using System.Collections.Generic;

namespace InsideDotNet.InsideDemos
{
    /*
     C# allows you to define generic classes, interfaces, abstract classes, fields, 
     methods, static methods, properties, events, delegates, and operators using 
     the type parameter and without the specific data type. A type parameter is a 
     placeholder for a particular type specified when creating an instance of the generic type.

     * A generic class increases the reusability. The more type parameters mean more reusable it becomes. 
       However, too much generalization makes code difficult to understand and maintain.
     * A generic class can be a base class to other generic or non-generic classes or abstract classes.
     * A generic class can be derived from other generic or non-generic interfaces, classes, 
       or abstract classes.
    */
    public class GenericsDemo
    {
        public void GenericClassMethods()
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            Console.WriteLine($"UseDataStore - get city by index: {cities.GetData(1)}");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine($"UseDataStore - get empId by index: {empIds.GetData(1)}");
        }
    }

    public class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
}
