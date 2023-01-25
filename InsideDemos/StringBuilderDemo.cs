using System;
using System.Text;

namespace InsideDotNet.InsideDemos
{
    internal class StringBuilderDemo
    {
        public void WorkWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder("Hello World!");
            StringBuilder sbNew = new StringBuilder();

            for (int i = 0; i < sb.Length; i++)
            {
                sbNew.Append(sb[i] + ".");
                Console.Write(sb[i]); // output: Hello World!
            }

            Console.Write(sb + Environment.NewLine);
            Console.Write(sbNew);
        }
    }
}
