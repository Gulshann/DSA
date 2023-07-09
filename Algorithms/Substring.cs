using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class Substring
    {
        public int StrStr(string haystack, string needle)
        {
            var tempArray = haystack.ToCharArray();
            var needleArrya = needle.ToCharArray();

            if (!haystack.Contains(needle))
            {
                return -1;
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                int temp = i;
                for (int j = 0; j < needleArrya.Length; j++)
                {
                    if (tempArray[i] != needleArrya[j])
                    {
                        i = temp;
                        break;
                    }
                    else
                    {
                        if (j == needleArrya.Length - 1)
                        {
                            return i - j;
                        }
                        i++;
                    }
                }
            }

            return -1;
        }
    }
}
