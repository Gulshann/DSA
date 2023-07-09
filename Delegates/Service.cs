using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSA.Delegate1
{
    public class Service
    {
        public async Task<int> Sum(int a, int b)
        {
            using (var reader = File.OpenText("C:\\StockURL.txt"))
            {
                var fileText = await reader.ReadToEndAsync();

            }
            return a + b;
        }

        public async Task CallMe()
        {
            //TestService test = new TestService();
            //var res = await test.CheckMe(Sum, 9, 18);
            //Console.WriteLine(res);

            int[] arr = { 2, 1, 5, 6, 2, 3 };
            int res=LargestRectangleArea(arr);

            res++;




        }

        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;

            int[] next = new int[n];
            next = nextSmallerElement(heights, n);

            int[] prev = new int[n];
            prev = prevSmallerElement(heights, n);

            int sum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int l = heights[i];

                if (next[i] == -1)
                {
                    next[i] = n;
                }


                int b = next[i] - prev[i] - 1;

                int newArea = l * b;

                sum = Math.Max(newArea, sum);
            }

            return sum;
        }

        private int[] prevSmallerElement(int[] arr, int n)
        {

            Stack<int> st = new Stack<int>();
            st.Push(-1);

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                int cur = arr[i];

                while (st.Peek() != -1 && arr[st.Peek()] >= cur)
                {
                    st.Pop();
                }
                res[i] = st.Peek();
                st.Push(i);
            }

            return res;
        }

        private int[] nextSmallerElement(int[] arr, int n)
        {

            Stack<int> st = new Stack<int>();
            st.Push(-1);
            int[] res = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                int cur = arr[i];

                while (st.Peek()!=-1 && arr[st.Peek()] >= cur)
                {
                    st.Pop();
                }
                res[i] = st.Peek();
                st.Push(i);
            }

            return res;
        }
    }
}
