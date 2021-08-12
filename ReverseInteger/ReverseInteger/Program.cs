using System;

namespace ReverseInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = -123;
            string strInput = input.ToString();

            Console.WriteLine("Input: {0}, length: {1}", strInput, strInput.Length);
        }
        public static int Reverse(int x)
        {
            string strVersion;
            string reversedStr = "";

            // Preserve whether it is positive or negative
            int sign = x >= 0 ? 1 : -1;

            try
            {
                strVersion = Math.Abs(x).ToString();
            }
            catch (OverflowException)
            {
                return 0;
            }


            for (int i = strVersion.Length - 1; i >= 0; i--)
            {
                reversedStr += strVersion[i];
            }

            if (Int32.TryParse(reversedStr, out int result))
                return result * sign;
            else
                return 0;
        }
    }
}
