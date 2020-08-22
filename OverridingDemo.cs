using System;

namespace InsideDotNet
{
    public class BaseClass
    {
        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    public class Derived : BaseClass
    {
        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    public class OverridingDemo
    {
        private BaseClass obj;

        public void SimpleOverriding()
        {
            // 'obj' is the object of class 'baseClass'
            obj = new BaseClass();

            // it invokes 'show()' of class 'baseClass'
            obj.show();

            // the same object 'obj' is now
            // the object of class 'derived'
            obj = new Derived();

            // it invokes 'show()' of class 'derived'
            // 'show()' of class 'derived' is overridden
            // for 'override' modifier
            obj.show();
        }
    }
}