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

       private bool IsSameDirection(int a, int b){
        if(a>=0 && b>=0){
            return true;
        }
        else if(a<0 && b<0){
            return true;
        }

        return false;
    }
    public int[] AsteroidCollision(int[] asteroids) {
        
        Stack<int> mainStack= new Stack<int>();

        foreach(var item in asteroids){
            if(mainStack.Count==0 ||(mainStack.Peek()<0 && item>0) || IsSameDirection(item, mainStack.Peek())){
                mainStack.Push(item);
            }
            else{
                if(mainStack.Count>0){

                    int topItem = mainStack.Peek();

                    int temp= item>0? item : -1*item;

                    while(true){

                        if(topItem>temp){
                            break;
                        }
                        else if(topItem<temp){
                            if(mainStack.Count==0 || topItem<0){
                                mainStack.Push(item);
                                break;
                            }
                            mainStack.Pop();
                            topItem = mainStack.Peek();
                        }
                        else{
                            mainStack.Pop();
                        }
                    }


                    
                    // if(temp>topItem){
                    //   mainStack.Push(item);   
                    // }
                    // else if(topItem>temp){
                    //     mainStack.Push(topItem);
                    // }
                    
                }
            }
        }

        List<int> res= new List<int>();

        Stack<int> tempStack = new Stack<int>();

        while(mainStack.Count!=0){
            tempStack.Push(mainStack.Pop());
        } 

        while(tempStack.Count!=0){
            res.Add(tempStack.Pop());
        }

        return res.ToArray();

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
