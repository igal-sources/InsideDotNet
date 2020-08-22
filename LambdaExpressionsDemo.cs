using System;
using System.Collections.Generic;
using System.Linq;

namespace InsideDotNet
{
    internal class LambdaStudent
    {
        public int rollNo { get; set; }
        public string name { get; set; }
        public int grades { get; set; }
    }

    public class LambdaExpressionsDemo
    {
        public void CalculateListElements()
        {
            // List to store numbers
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

            // foreach loop to dislay the list
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression to calculate square of
            // each value in the list
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda exression to find all
            // numbers in the list divisible by 3
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            // foreach loop to display divBy3
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
        }

        public void LambdaOperationsOnUserDefinedClass()
        {
            // List with each element of type Student 
            List<LambdaStudent> details = new List<LambdaStudent>() {
            new LambdaStudent{ rollNo = 1, grades = 95, name = "Liza" },
            new LambdaStudent{ rollNo = 2, grades = 55, name = "Stewart" },
            new LambdaStudent{ rollNo = 3, grades = 60, name = "Tina" },
            new LambdaStudent{ rollNo = 4, grades = 75, name = "Stefani" },
            new LambdaStudent{ rollNo = 5, grades = 65, name = "Trish" }
        };

            // To sort the details list based on name of student 
            // in acsending order 
            Console.WriteLine("Sort the details list based on name of student");
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }

            Console.WriteLine("Students with grades up to 70");
            var studentGrades = details.Where(x => x.grades >= 70);

            foreach (var value in studentGrades)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
        }
    }
}