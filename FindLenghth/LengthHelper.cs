using System;

namespace FindLenghth
{
    public class LengthHelper
    {
        public static void Main()
        {
            string str;
            int length;
            str = Console.ReadLine();
            length = findLength(str);

            Console.Write("Length of string is: {0}\n", length);
            Console.ReadLine();
        }

        public static int findLength(string str)
        {
            int len = 0;
            if (str != null)
            {
                foreach (char ch in str)
                {
                    len += 1;
                }
                return len;
            }
            else
            {
                throw new NullReferenceException("Null value is invalid.");
            }
        }
    }
}
