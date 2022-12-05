using System;
using System.Collections.Generic;
using System.Linq;

namespace InsideDotNet
{
    public class StudentItem
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Mobile { get; set; }
    }

    public class GenericCollectionsDemo
    {
        /// <summary>
        /// Generic List<T> contains elements of specified type. 
        /// It grows automatically as you add elements in it.
        /// </summary>
        private void SimpleListOfStrings()
        {
            var cities = new List<string>
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago",
                null// nulls are allowed for reference type list
            };

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
        }

        private void ListOfObject()
        {
            var students = new List<StudentItem>() {
                new StudentItem(){ Id = 1, StudentName= "Bill",  Mobile= "1222"},
                new StudentItem(){ Id = 2, StudentName= "Steve", Mobile= "3333"},
                new StudentItem(){ Id = 3, StudentName= "Ram",   Mobile= "4444"},
                new StudentItem(){ Id = 4, StudentName= "Abdul", Mobile= "5555"}
            };

            // using foreach LINQ method
            students.ForEach(num => Console.WriteLine(num.StudentName + ", "));

            //get all students whose name is Bill
            var result = from s in students
                         where s.StudentName == "Bill"
                         select s;

            foreach (var student in result)
            {
                Console.WriteLine(student.Id + ", " + student.StudentName);
            }

            //Insert elements into List
            students.Insert(0, new StudentItem() { Id = 0, StudentName = "First", Mobile = "0000" });
        }

        private void AddArraysInList()
        {
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);
        }

        /// <summary>
        /// Dictionary<TKey,TValue> contains key-value pairs.
        /// </summary>
        private void DictionaryDemo()
        {

        }

        /// <summary>
        /// SortedList stores key and value pairs. It automatically adds 
        /// the elements in ascending order of key by default.
        /// </summary>
        public void SortedListDemo()
        {
            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>
            {
                { 3, "Three" },
                { 1, "One" },
                { 2, "Two" },
                { 4, null },
                { 10, "Ten" },
                { 5, "Five" }
            };

            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            numberNames.Add(6, "Six");
            numberNames.Add(7, "Seven");
            //numberNames.Add(4, "Four");//[System.ArgumentException: An entry with the same key already exists.]
            
            Console.WriteLine(numberNames);

            //using collection-initializer syntax
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            var res = cities.Where(x => x.Key == "London");
            Console.WriteLine(res.First().Value);
        }

        /// <summary>
        /// Queue<T> stores the values in FIFO style (First In First Out). 
        /// It keeps the order in which the values were added. It provides 
        /// an Enqueue() method to add values and a Dequeue() method to 
        /// retrieve values from the collection.
        /// </summary>
        private void QueueDemo()
        {
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); //prints H
                Console.WriteLine(strQ.Peek()); //prints H
            }

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
            strQ.Contains("e"); //true
        }

        /// <summary>
        /// Stack<T> stores the values as LIFO (Last In First Out). 
        /// It provides a Push() method to add a value and Pop() & Peek() 
        /// methods to retrieve values.
        /// </summary>
        private void StackDemo()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 4
                Console.WriteLine(myStack.Peek()); // prints 4
            }
        }

        /// <summary>
        /// Hashset<T> contains non-duplicate elements. It eliminates duplicate elements.
        /// </summary>
        private void HashsetDemo()
        {

        }
    }
}
