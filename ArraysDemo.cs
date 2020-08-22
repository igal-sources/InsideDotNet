using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideDotNet
{
    public class ArraysDemo
    {
        private void DaysOfWeek()
        {
            // allocating memory for days. 
            string[] weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

            // Displaying Elements of array 
            foreach (string day in weekDays)
                Console.Write(day + " ");
        }

        private void TwoDimensionalArray()
        {
            // Two-dimensional array 
            int[,] intarray = new int[,] { { 1, 2 },{ 3, 4 },{ 5, 6 },{ 7, 8 } };

            // Accessing array elements. 
            Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);
        }

        private void ArrayWith2Elements()
        {
            // Declare the array of two elements: 
            int[][] arr = new int[2][];

            // Initialize the elements: 
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements: 
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public ArraysDemo()
        {
            DaysOfWeek();
            TwoDimensionalArray();
            ArrayWith2Elements();
            Console.WriteLine("");
        }
    }
}
