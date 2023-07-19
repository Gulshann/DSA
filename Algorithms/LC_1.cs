using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class LC_1
    {
        public LC_1()
        {
           Console.WriteLine(RemoveStars("leet**cod*e"));
        }

        public string RemoveStars(string s)
        {
            char[] tempArray = s.ToCharArray();

            Stack<char> mainStack = new Stack<char>();

            Stack<char> tempStack = new Stack<char>();

            foreach(var item in tempArray)
            {
                if(item!='*')
                    mainStack.Push(item);
                else
                {
                    if (mainStack.Count > 0)
                    {
                        mainStack.Pop();
                    }
                }
            }

            foreach(var item in mainStack)
            {
                tempStack.Push(item);
            }

            StringBuilder res = new StringBuilder();

            while (tempStack.Count > 0)
            {
                res.Append(tempStack.Pop());
            }


            return res.ToString();
        }
    }
}
