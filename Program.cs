using System;
using static InsideDotNet.DelegatesDemo;

namespace InsideDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region InsidDelegates
            //var obj = new InsideDelegates();
            //addnum del_obj1 = new addnum(obj.Sum);
            //subnum del_obj2 = new subnum(obj.Subtract);

            //// pass the values to the methods by delegate object 
            //del_obj1(100, 40);
            //del_obj2(100, 60);

            //// These can be written as using "Invoke" method 
            // del_obj1.Invoke(100, 40); 
            // del_obj2.Invoke(100, 60);
            //#endregion

            //#region InsideLambdaExpressions

            //var lambda = new InsideLambdaExpressions();
            //lambda.LambdaOperationsOnUserDefinedClass();
            //#endregion

            #region FileHandlingDemo

            FileHandlingDemo fhd = new FileHandlingDemo();
            fhd.ReadingFile();
            #endregion

            #region ReflectionDemo

            //ReflectionDemo refl = new ReflectionDemo();
            //refl.ReflectionInvokeMethod();
            #endregion

            #region InsideCustomAttributes

            //var attr = new CustomAttributesDemo();
            //attr.CustomAttributesExample();
            #endregion

            //SerializationDemo ser = new SerializationDemo();
            //var events = ser.DeserializeEvents();

            //string eventsString = ser.SerializeEvents(events);
            Console.ReadKey();
        }
    }
}
