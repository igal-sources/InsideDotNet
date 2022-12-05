using System;
using System.Reflection;

namespace InsideDotNet.InsideDemos
{
    //The code shows an example of a Custom Attribute named MyAttribute,
    //which has two private members namely 'name' and 'action'.
    //The 'name' is used for defining a name for any program element that
    //the attribute may be applied to.
    //The 'action' describes what the element is supposed to do.
    //Here the attributes are applied to methods to class Student.
    [AttributeUsage(AttributeTargets.All)]
    internal class ActionAttrAttribute : Attribute
    {
        public ActionAttrAttribute(string name, string action)
        {
            Name = name;
            Action = action;
        }

        public string Name { get; }
        public string Action { get; }

        // Method to show the Fields
        // of the NewAttribute
        // using reflection
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);

            // Array to store all methods of a class
            // to which the attribute may be applied
            MethodInfo[] methods = classType.GetMethods();

            // for loop to read through all methods
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                // Creating object array to receive method attributes returned
                // by the GetCustomAttributes method
                object[] attributesArray = methods[i].GetCustomAttributes(true);

                // foreach loop to read through
                // all attributes of the method
                foreach (Attribute item in attributesArray)
                {
                    if (item is ActionAttrAttribute)
                    {
                        // Display the fields of the NewAttribute
                        ActionAttrAttribute attributeObject = (ActionAttrAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                         attributeObject.Name, attributeObject.Action);
                    }
                }
            }
        }
    }

    internal class Student
    {
        private int rollNo;
        private string stuName;
        private double marks;

        // The attribute MyAttribute is applied
        // to methods of class Student
        // Providing details of their utility
        [ActionAttr("Modifier", "Assigns the Student Details")]
        public void SetDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        [ActionAttr("Accessor", "Returns Value of rollNo")]
        public int GetRollNo()
        {
            return rollNo;
        }

        [ActionAttr("Accessor", "Returns Value of stuName")]
        public string GetStuName()
        {
            return stuName;
        }

        [ActionAttr("Accessor", "Returns Value of marks")]
        public double GetMarks()
        {
            return marks;
        }
    }

    internal class CustomAttributesDemo
    {
        internal void CustomAttributesExample()
        {
            Student student = new Student();
            student.SetDetails(1, "Taylor", 92.5);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + student.GetRollNo());
            Console.WriteLine("Name : " + student.GetStuName());
            Console.WriteLine("Marks : " + student.GetMarks());

            Console.WriteLine();
            ActionAttrAttribute.AttributeDisplay(typeof(Student));
        }
    }
}