using System;

namespace InsideDotNet.DataContracts
{
    class Student
    {
        // Properties definition 
        public int RollNo { get; set; }
        public string Name { get; set; }

        // No Argument Constructor 
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor 
        public Student(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        // Method to Display Student Data 
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }

}
