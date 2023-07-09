using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class Subset
    {

        public Subset()
        {
            //PowerSet("ABC", 0, "");

            List<int> list = new List<int>() { 1, 2, 3 };
            List<List<int>> result = PowerSet(list);
            //foreach(var item in result)
            //{
            //    foreach(var i in item)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //    Console.WriteLine();
            //}
        }
         
        public List<List<int>> PowerSet(List<int> list)
        {
            List<List<int>> result = new List<List<int>>();
            //List<int> output = null;
            int index = 0;

            Solve(list, index, new List<int>(), result);


            return result;
        }

        private void Solve(List<int> list, int index, List<int> output, List<List<int>> result)
        {
            if (index >= list.Count)
            {
                result.Add(output);
                return;
            }

            //Exclude 
            Solve(list, index + 1, output, result);

            int element = list[index];
            output.Add(element);

            Solve(list, index + 1, output, result);

        }

        private void PowerSet(string input, int i, string output)
        {
            if (input.Length == i)
            {
                Console.WriteLine(output);
                return;
            }

            PowerSet(input, i + 1, output);

            PowerSet(input, i + 1, output + input[i]);
        }
    }
}
