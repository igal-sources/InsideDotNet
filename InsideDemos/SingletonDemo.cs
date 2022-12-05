using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideDotNet.InsideDemos
{
    public class SingletonDemo
    {
        private static SingletonDemo _instance;

        private SingletonDemo()
        {
        }

        public static SingletonDemo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonDemo();

                return _instance;
            }
        }

        public void DoSingletonOperation()
        {
            Console.WriteLine("singleton operation");
        }
    }
}
