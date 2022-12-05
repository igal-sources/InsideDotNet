using System;
using System.Collections.Generic;
using System.Linq;

namespace InsideDotNet.InsideDemos
{
    internal class LINQDemo
    {
        public void LinqExample()
        {
            // Data source
            List<string> my_list = new List<string>()
            {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
            };

            // Creating LINQ Query
            var res = from l in my_list
                      where l.Contains("my")
                      select l;

            // Executing LINQ Query
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }
        }
    }
}