using System;

namespace InsideDotNet.Helpers
{
    public class GeneralHelper
    {
        public int ByteArrayToInt(byte[] bytes)
        {
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            int i = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine("int: {0}", i);
            return i;
        }

        public void StringToHexadecimal(string input)
        {
            char[] values = input.ToCharArray();
            foreach (char letter in values)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the integer value to a hexadecimal value in string form.
                Console.WriteLine($"Hexadecimal value of {letter} is {value:X}");
            }
        }

        public void HexadecimalToString(string hexValues)
        {
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach (string hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer.
                int value = Convert.ToInt32(hex, 16);
                // Get the character corresponding to the integral value.
                string stringValue = Char.ConvertFromUtf32(value);
                char charValue = (char)value;
                Console.WriteLine("hexadecimal value = {0}, int value = {1}, char value = {2} or {3}",
                                    hex, value, stringValue, charValue);
            }
        }

        public float HexadecimalToFloat(string hexString)
        {
            uint num = uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);

            byte[] floatVals = BitConverter.GetBytes(num);
            float f = BitConverter.ToSingle(floatVals, 0);
            Console.WriteLine("float convert = {0}", f);
            return f;
        }

        public int HexadecimalToInt(string hexString)
        {
            int num = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            return num;
        }

        public string ByteArrayToHexadecimal(byte[] vals)
        {
            string str = BitConverter.ToString(vals);
            Console.WriteLine(str);

            str = BitConverter.ToString(vals).Replace("-", "");
            Console.WriteLine(str);
            return str;
        }
    }
}
