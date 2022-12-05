using System;

namespace InsideDotNet.InsideDemos
{
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
