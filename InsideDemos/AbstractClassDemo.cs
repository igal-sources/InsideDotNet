using System;

namespace InsideDotNet.InsideDemos
{
    /*
     C# abstract class explained
        An abstract class is a special type of class that cannot be instantiated. 
        An abstract class is designed to be inherited by subclasses that either
        implement or override its methods. In other words, abstract classes are
        either partially implemented or not implemented at all. 
        You can have functionality in your abstract class—the methods in an abstract
        class can be both abstract and concrete. An abstract class can have
        constructors—this is one major difference between an abstract class and
        an interface. You can take advantage of abstract classes to design components
        and specify some level of common functionality that must be implemented by derived classes.
     */
    public abstract class GeeksForGeeks
    {
        public abstract void Geeks();
    }

    public class Geek1 : GeeksForGeeks
    {
        public override void Geeks()
        {
            Console.WriteLine("class Geek1");
        }
    }

    public class Geek2 : GeeksForGeeks
    {
        public override void Geeks()
        {
            Console.WriteLine("class Geek2");
        }
    }
    /// <summary>
    /// Process to hide the internal details and showing only the functionality. 
    /// The abstract modifier indicates the incomplete implementation.
    /// </summary>
    public class AbstractClassDemo
    {
        public void AbstractSample()
        {
            GeeksForGeeks geek;

            // instantiate class 'Geek1' 
            geek = new Geek1();

            // call 'Geeks()' of class 'Geek1' 
            geek.Geeks();

            // instantiate class 'Geek2'   
            geek = new Geek2();

            // call 'Geeks()' of class 'Geek2' 
            geek.Geeks();
        }
    }
}
