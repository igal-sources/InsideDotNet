using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideDotNet.InsideDemos
{
    public partial class PartialClassesDemo
    {
        private string AuthorName;
        private int TotalArticles;

        public PartialClassesDemo(string a, int t)
        {
            AuthorName = a;
            TotalArticles = t;
        }
    }

    public partial class PartialClassesDemo
    {
        public void Display()
        {
            Console.WriteLine("Author's name is : " + AuthorName);
            Console.WriteLine("Total number articles is : " + TotalArticles);
        }
    }
}
