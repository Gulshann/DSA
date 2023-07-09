using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Base
{
    public class Numbers
    {
        public Numbers()
        {
           int res= ClimpStairs(5);

            int re1=NumDecodings("2101");
        }

        public int NumDecodings(string s)
        {

            if (s[0].Equals('0')) return 0;

            char[] tempArray = s.ToCharArray();

            int start = 0;
            int end = 1;

            int result = 1;

            if (s.Contains("0")) result = 0;

            while (end < tempArray.Length)
            {

                string a = tempArray[start++].ToString();
                string b = tempArray[end++].ToString();

                string c = a + b;

                if (c[0].Equals('0'))
                {
                    result--;
                    continue;
                }

                int temp = Convert.ToInt32(c);

                if (temp <= 26 && temp > 0)
                {
                    result++;
                }
            }

            return result;
        }

        private int ClimpStairs(int v)
        {
            if (v == 1 || v==0)
            {
                return 1;
            }
            return ClimpStairs(v - 1) + ClimpStairs(v - 2);
        }

        public string AddBinary(string a, string b)
        {

            long res = BinaryToDecimal(a) + BinaryToDecimal(b);

            return DecimalToBinary(res);

        }

        private long BinaryToDecimal(string binary)
        {

            if (binary == "0") return 0;
            long num = 0;

            char[] tempArray = binary.ToCharArray();

            int length = tempArray.Length;

            for (int i = length - 1; i >= 0; i--)
            {

                num += Convert.ToInt64(tempArray[i].ToString()) * (long)Math.Pow(2, length - i - 1);
            }

            return num;
        }

        private string DecimalToBinary(long n)
        {

            if (n == 0) return "0";

            Stack<long> binaryNum = new Stack<long>();

            long i = 0;
            while (n > 0)
            {
                binaryNum.Push(n % 2);
                n = n / 2;
                i++;
            }

            StringBuilder res = new StringBuilder();
            // // printing binary array in reverse order
            // for (int j = i - 1; j >= 0; j--)
            // {

            // }

            while (binaryNum.Count > 0)
            {
                res.Append(binaryNum.Pop());
            }

            return res.ToString();


        }


    }
}
