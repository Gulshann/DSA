using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DSA.Oops
{
    public class Circle
    {
        static float PI;
        int radius;

        static Circle()
        {
            Circle.PI = 3.14F;  //Only to assign static fields
        }

        public Circle(int radius)
        {
            //RemoveDuplicateLetters("cbacdcbc");
            //BulbSwitch(4);
            //PivotInteger(8);
            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //MaxSubArray(arr);
            this.radius = radius;
        }

        public static void Print()
        {

        }

        public float CalculateArea(string s)
        {
            Dictionary<char, int> tempDict = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (!tempDict.ContainsKey(ch))
                {
                    tempDict.Add(ch, 1);
                }
                else
                {
                    tempDict[ch]++;
                }
            }

            var dict = tempDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            StringBuilder sb = new StringBuilder();
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    sb.Append(item.Key);
                }
            }

            Console.WriteLine(sb.ToString());




            return Circle.PI * this.radius * this.radius;
        }

        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int tempSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        tempSum += nums[k];
                    }
                    if (maxSum < tempSum)
                        maxSum = tempSum;
                }

            }
            return maxSum;
        }

        // -2, 3, -1, 4
        //public int MaxSubArray(int[] nums, int index, int max)
        //{
        //    if (index == nums.Length - 1)
        //        return max;

        //    int sum = 0;
        //    for(int i=0; i <= index; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    if (max < sum)
        //        max = sum;

        //    return MaxSubArray(nums, index + 1, max);
        //}

        public int PivotInteger(int n)
        {
            int totalSum = n * (n + 1) / 2;

            for (int i = 1; i <= n; i++)
            {
                int tempSum = i * (i + 1) / 2;
                if (tempSum == totalSum - tempSum + i)
                {
                    return i;
                }
            }
            return -1;
        }

        public int BulbSwitch(int n)
        {

            Dictionary<int, bool> tempDict = new Dictionary<int, bool>();
            for (int i = 1; i <= n; i++)
            {
                tempDict.Add(i, false);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j += i)
                {
                    tempDict[j] = tempDict[j] == false ? true : false;
                }
            }
           int k= (int)Math.Sqrt(n);

            List<char> tempList = new List<char>();
            tempList.OrderBy(x => x);

            return tempDict.Where(x => x.Value == true).Count();

        }

        public string RemoveDuplicateLetters(string s)
        {
            List<char> tempList = new List<char>();

            foreach (char ch in s)
            {
                if (!tempList.Contains(ch))
                {
                    tempList.Add(ch);
                }
            }

           tempList= tempList.OrderBy(x => x).ToList();
            return new string(tempList.ToArray());
        }
    }
}
