using InsideDotNet.DataContracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InsideDotNet.InsideDemos
{
    public class CollectionsDemo
    {
        /// <summary>
        /// ArrayList stores objects of any type like an array.
        /// However, there is no need to specify the size of the
        /// ArrayList like with an array as it grows automatically.
        /// </summary>
        private void ArrayListDemo()
        {
            ArrayList myList = new ArrayList
            {
                "A", "B", "C", "D", "E", "F", "G", "H"
            };

            foreach (var arr in myList)
            {
                Console.WriteLine(arr);
            }

            bool containsLetter = myList.Contains("E");

            IEnumerator enumerator = myList.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private void ListGenericsDemo()
        {
            List<EventTypes> myList = new List<EventTypes>();
            {
                new EventTypes() { EventTypeId = 1, EventTypeName = "Event1" };
                new EventTypes() { EventTypeId = 2, EventTypeName = "Event2" };
                new EventTypes() { EventTypeId = 3, EventTypeName = "Event3" };
                new EventTypes() { EventTypeId = 4, EventTypeName = "Event4" };
            };

            foreach (var arr in myList)
            {
                Console.WriteLine(arr);
            }

            var find = myList.Find(ev => ev.EventTypeName == "Event2");
            var contains = myList.Where(ev => ev.EventTypeName == "Event2").FirstOrDefault();

            IEnumerator enumerator = myList.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        /// <summary>
        /// Hashtable stores key and value pairs. It retrieves the values
        /// by comparing the hash value of the keys.
        /// </summary>
        private void HashtableDemo()
        {
            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
            //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
        }

        /// <summary>
        /// BitArray manages a compact array of bit values, which are represented
        /// as Booleans, where true indicates that the bit is on (1) and false
        /// indicates the bit is off (0).
        /// </summary>
        private void BitArrayDemo()
        { 
            
        }
    }
}