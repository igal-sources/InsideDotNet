using System;

namespace InsideDotNet.DataContracts
{
    public class AssemblyClassDemo
    {
        public int IntVariable { get; set; }
        public string StringVariable { get; set; }
        public bool BoolVariable { get; set; }
        public float FloatVariable { get; set; }

        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public string GetMyName(string name)
        {
            return $"Hi {name}, nice to meat you...";
        }

        public void DisplayVariables()
        {
            IntVariable = 10;
            StringVariable = "String Variable";
            BoolVariable = true;
            FloatVariable = 14.55f;
            Console.WriteLine($"Int Variable: {IntVariable}\nString Variable: {StringVariable}");
        }
    }
}
