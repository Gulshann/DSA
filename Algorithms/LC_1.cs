using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class LC_1
    {
        public LC_1()
        {
                int[] arr = {5,10,-5};
                AsteroidCollision(arr);
            //Console.WriteLine(RemoveStars("leet**cod*e"));
        }

         public string GcdOfStrings(string str1, string str2) {
        
       return (str1+str2 == str2+str1) ? str1.Substring(0, gcd(str1.Length, str2.Length)): "";
    }

       public int[] AsteroidCollision(int[] asteroids) {
        
        Stack<int> mainStack = new Stack<int>();

            foreach (var item in asteroids)
            {
                if (mainStack.Count == 0 || (mainStack.Peek() < 0 && item > 0) || IsSameDirection(item, mainStack.Peek()))
                {
                    mainStack.Push(item);
                }
                else
                {
                    while(mainStack.Count>0 && mainStack.Peek()>0 && mainStack.Peek() < Math.Abs(item)){
                        mainStack.Pop();
                    }

                    if(mainStack.Count == 0 || mainStack.Peek()<0){
                        mainStack.Push(item);
                    }
                    else if( mainStack.Peek()==Math.Abs(item)){
                        mainStack.Pop();
                    }
                }
            }

            List<int> res = new List<int>();

            Stack<int> tempStack = new Stack<int>();

            while (mainStack.Count != 0)
            {
                tempStack.Push(mainStack.Pop());
            }

            while (tempStack.Count != 0)
            {
                res.Add(tempStack.Pop());
            }

            return res.ToArray();

    }

        private bool IsSameDirection(int item, int v)
        {
            if(item>0 && v>0) return true;
            else if(item<0 && v<0) return true;

            return false;
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

        public int gcd(int a, int b){
            if(b==0) return a;

            return gcd(b, a%b);
        }
    }
}
