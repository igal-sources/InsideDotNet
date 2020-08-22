using System;

namespace InsideDotNet
{
    // declaring an interface
    public interface InterfaceA
    {
        // method of interface
        void Mymethod1();

        void Mymethod2();
    }

    // The methods of interface A
    // is inherited into interface B
    public interface InterfaceB : InterfaceA
    {
        // method of interface B
        void mymethod3();
    }

    // Below class is inherting
    // only interface B
    // This class must
    // implement both interfaces
    internal class Geeks : InterfaceB
    {
        // implementing the method
        // of interface A
        public void Mymethod1()
        {
            Console.WriteLine("Implement method 1");
        }

        // Implement the method
        // of interface A
        public void Mymethod2()
        {
            Console.WriteLine("Implement method 2");
        }

        // Implement the method
        // of interface B
        public void mymethod3()
        {
            Console.WriteLine("Implement method 3");
        }
    }

    public class InterfacesInheritanceDemo
    {
        public void WorkWithInterfaces()
        {
            // creating the object class of Geeks
            Geeks obj = new Geeks();

            // calling the method using object 'obj'
            obj.Mymethod1();
            obj.Mymethod2();
            obj.mymethod3();
        }
    }
}