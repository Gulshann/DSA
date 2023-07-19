using DSA.Algorithms;
using DSA.Oops;
using System;
using System.IO;
using DSA.Pattern;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using DSA.Multithreading;
using System.Threading;
using DSA.Delegate1;
using static DSA.Algorithms.LinkedList1;
using DSA.Base;
using DSA.Algorithms.Graphs;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {


            LC_1 lc = new LC_1();
            // Graph graph = new Graph();
            // graph.PrintGraph();

            // Console.WriteLine("Breadth First Search : ");
            // graph.BFS();
            // Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            // Console.WriteLine("Depth First Search : ");
            // graph.DFS();

            //Numbers numbers = new Numbers();
            //string num=numbers.AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011");

            //numbers.DecimalToBinary(0);
            //Console.WriteLine(num);
            //var existingDataDict = new Dictionary<string, string>();
            //existingDataDict.Add("abc", "0.9");

            //var currentDataDict = new Dictionary<string, string>();
            //currentDataDict.Add("abc", "0.9");

            //string key = "abc";

            //if (double.TryParse(existingDataDict[key], out double existingValue) && currentDataDict.TryGetValue(key, out string currentValue) && double.TryParse(currentValue, out double currentValueInt))
            //{
            //    existingDataDict[key] = Convert.ToString(existingValue + currentValueInt);
            //}

            //var m = existingDataDict[key];
            //Substring sb = new Substring();
            //int res=sb.StrStr("mississippi", "issip");
            //int temp = 3 % 5 - 1;
            //Service se = new Service();
            //se.CallMe();
            //int[] widths = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            // NumberOfLines(widths, "bbbcccdddaaa");
            //char c = 'a';
            //byte asciiValue = System.Convert.ToByte(c);
            //int m=Convert.ToInt32(asciiValue);
            //int[][] myArray = { new int[]{ 1, 1 }, new int[] { 3, 2 }, new int[] { 5, 3 }, new int[] { 4, 1 }, new int[] { 2, 3 }, new int[] { 1, 4 } };
            //int res=MaxPoints(myArray);

            //_15Feb feb = new _15Feb();

            //MultipleThread multiple = new MultipleThread();

            //int n = 20;

            //FizzBuzz fizzBuzz = new FizzBuzz(n);

            //for(int i = 1; i <= n; i++)
            //{
            //    if(i%3==0 && i % 5 != 0)
            //    {
            //        Thread thread = new Thread(() => fizzBuzz.Fizz(printFizz));
            //        thread.Start();
            //    }
            //    else if(i%3!=0 && i % 5 == 0)
            //    {
            //        Thread thread = new Thread(() => fizzBuzz.Buzz(printBuzz));
            //        thread.Start();
            //    }
            //    else if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Thread thread = new Thread(() => fizzBuzz.Fizzbuzz(printFizzBuzz));
            //        thread.Start();
            //    }
            //    else
            //    {
            //        Thread thread = new Thread(() => fizzBuzz.Fizzbuzz(()=>printNumber(i)));
            //        thread.Start();
            //    }
            //}


            ////IPValidations ip = new IPValidations();
            //LinkedList1 list = new LinkedList1();

            //string[] arr1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var res = GroupAnagrams(arr1);
            //var properties = typeof(ServiceUIPlaceholders).GetFields();
            //var dynamicPlaceholdersDict = new Dictionary<string, string>();
            //using (StreamReader reader = new StreamReader("./json1.json"))
            //{
            //    string dynamicTextJson = reader.ReadToEnd();
            //     dynamicPlaceholdersDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(dynamicTextJson);
            //}

            //var dict = new Dictionary<string, string>();
            //int t = 0;
            //foreach(var item in properties)
            //{
            //    string key = item.GetValue(null).ToString();
            //    string value = dynamicPlaceholdersDict[item.Name];
            //    dict.Add(key, value);
            //    //if (!dict.ContainsKey(key))
            //    //{
            //    //    dict.Add(key, value);
            //    //}

            //}

            //var result = JsonConvert.SerializeObject(dict);

            //Tree tree = new Tree();
            // int[] nums = { -1, 0, 1, 2, -1, -4 };
            //var res= ThreeSum(nums);
            //MajorityElement(nums);
            //Tree tree = new Tree();
            //GrayCode(4);
            //List_ list = new List_();
            //list.head = new Node(1);
            //list.head.next = new Node(2);
            //list.head.next.next = new Node(3);
            //list.head.next.next.next = new Node(4);
            //list.head.next.next.next.next = new Node(5);
            //list.head.next.next.next.next.next = new Node(6);
            //list.head.next.next.next.next.next.next
            //= new Node(7);

            //Console.WriteLine(
            //"Linked List_ before removing duplicates: ");
            //list.printList(list.head);

            //list.ReverseBetween(list.head, 2,5);

            //list.remove_duplicates();
            //Console.WriteLine("");
            //Console.WriteLine(
            //"Linked List_ after removing duplicates: ");
            //list.printList(list.head);

            //int[] arr = { 3, 5, 3, 2, 0 };
            //int res =PeakIndexInMountainArray(arr);

            //Backtracking b = new Backtracking();

            //int[][] arr = new int[5][];
            //arr[0] = new int[] { 1, 4, 7, 11, 15 };
            //arr[1] = new int[] { 2, 5, 8, 12, 19 };
            //arr[2] = new int[] { 3, 6, 9, 16, 2 };
            //arr[3] = new int[] { 10, 13, 14, 17, 24 };
            //arr[4] = new int[] { 18, 21, 23, 26, 30 };

            //SortingAlgorthims sorting = new SortingAlgorthims();
            //bool result = sorting.SearchMatrix(arr, 5);

            //string res = sorting.AddStrings("11", "123");

            // bool res = WordPattern("abc", "dog cat dog");
            //arr[2] = new int[] { 8,10 };
            //arr[3] = new int[] { 15,18 };
            //Merge(arr);
            //PatternProgramming p = new PatternProgramming();
            //p.SearchMatrix(arr, 3);

            //WriteIntoFile();

            //OopsConcepts();

            //MultipleThread mt = new MultipleThread();


            //Subset s = new Subset();

            //int[] arr = { 3, 5, 1, 6, 2, 9, 4, 7 };

            //SortingAlgorthims sorting = new SortingAlgorthims();

            //sorting.BubbleSortRec(arr,0, arr.Length-1);

            ////sorting.InsertionSortRec(arr, 1, arr.Length-1);

            ////sorting.QuickSortRec(arr, 0, arr.Length - 1);

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
        }

        public static int[] NumberOfLines(int[] widths, string s)
        {

            var res = new int[2];

            res[0] = 1;

            int maxLineLength = 100;

            for (var i = 0; i < s.Length; i++)
            {

                byte asciiValue = System.Convert.ToByte(s[i]);
                int index = Convert.ToInt32(asciiValue);

                int pixelLength = widths[index - 97];

                int remain = maxLineLength - pixelLength;

                if (remain > 0)
                {
                    maxLineLength = remain;
                }
                else
                {
                    res[0]++;
                    maxLineLength = 100- pixelLength;
                    }
                if (i == s.Length - 1)
                {
                    res[1] = 100 - maxLineLength;
                }
            }

            return res;
        }

        private static void WriteIntoFile()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Practice\msisdn.txt"))
            {
                for (int i = 1; i <= 80000000; i++)
                {
                    writer.Write("99029393993, ");
                }
            }
        }

        private static void OopsConcepts()
        {
            //Lecture 1
            //Customer customer = new Customer("Ram", "Singh");
            //customer.GetFullName();

            //Customer customer1 = new Customer();
            //customer1.GetFullName();
            //int res=customer1.Calc(2, 3,4,5);
            //int res1 = customer1.Calc(new int[] { 1, 2 });

            //Lecture 2 - Static
            //Circle.Print();

            //PatternProgramming pattern = new PatternProgramming();
            //pattern.Pattern1(4);

            //Circle c1 = new Circle(5);
            //float result1 = c1.CalculateArea("aabbbacccccd");
            //Console.WriteLine($"Area1 - {result1}");


            //Circle c2 = new Circle(7);
            //float result2 = c2.CalculateArea();
            //Console.WriteLine($"Area2 - {result2}");

            //Inheritence

            FullTimeEmployee fte = new FullTimeEmployee("Aryan", "Kumar");
            fte.FirstName = "Gulshan";
            fte.LastName = "Pandey";
            fte.YearlySalary = 500000;
            
            fte.PrintFullName();

            //PartTimeEmployee pte = new PartTimeEmployee();
            //pte.FirstName = "Mike";
            //pte.LastName = "Hussey";
            //pte.HourlySalary = 500;
            //pte.PrintFullName();

            //Employee emp = new PartTimeEmployee();
            //PartTimeEmployee pte =(PartTimeEmployee) new Employee();

            Vehicle vehicle = new Car();
            vehicle.start();
            vehicle.run();

        }
        //  3,5,3,2,0
        public static int PeakIndexInMountainArray(int[] arr)
        {

            long mid1 = (1 + 16) >> 1;

            int start = 0, end = arr.Length - 1;
            // 1 2 9 5 4 3 2 1
            // 1 2 3 4 5 9 2 1
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }
                else if (arr[mid] < arr[mid - 1])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> tempDict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (tempDict.ContainsKey(item))
                {
                    tempDict[item]++;
                }
                else
                {
                    tempDict.Add(item, 1);
                }
            }
            return tempDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Select(x => x.Key).FirstOrDefault();
            //return tempDict.OrderBy(x => x.Value);
        }

        public static IList<int> GrayCode(int n)
        {
            IList<int> result = new List<int>();


            Dictionary<int, int> tempDict = new Dictionary<int, int>();

            tempDict.OrderBy(x => x.Value).Select(x => x.Key);

            int count = (int)Math.Pow(2, n);

            for (int i = 0; i < count; i++)
            {
                string binaryTemp = Convert.ToString(i, 2);

                if (i == 0 || i == 1)
                {
                    result.Add(i);
                }
                else
                {
                    StringBuilder binaryGrey = new StringBuilder();

                    for (int j = 0; j < binaryTemp.Length; j++)
                    {
                        if (j == 0)
                        {
                            binaryGrey.Append(binaryTemp[j]);
                        }
                        else
                        {
                            binaryGrey.Append(binaryTemp[j - 1] ^ binaryTemp[j]);
                        }
                    }

                    int tempResult = Convert.ToInt32(binaryGrey.ToString(), 2);
                    result.Add(tempResult);
                }
            }
            return result;
        }

        private static int GCD(int v1, int v2)
        {
            if (v2 == 0)
                return v1;
            else
                return GCD(v2, v1 % v2);   // (50, 35) -> (35, 15) -> (15, 5) -> (5, 0)
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] >= nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            int start, end;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                start = i + 1;
                end = nums.Length - 1;

                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];



                    if (sum == 0)
                    {
                        List<int> tempList = new List<int>() { nums[i], nums[start], nums[end] };
                        result.Add(tempList);
                        break;
                    }
                    else if (sum < 0)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }

            }
            return result;
        }

        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals.Length == 1) return intervals;
            List<List<int>> result = new List<List<int>>();

            int start = 0;
            int end = intervals.Length - 1;

            List<int> arr1 = new List<int>();
            List<int> arr2 = new List<int>();
            for (int i = 0; i < intervals.Length; i++)
            {
                arr1.Add(intervals[i][0]);
                arr2.Add(intervals[i][1]);
            }

            arr1 = arr1.OrderBy(x => x).ToList();
            arr2 = arr2.OrderBy(x => x).ToList();

            while (start < end)
            {
                List<int> temp = new List<int>();
                temp.Add(arr1[start]);
                bool isDone = false;
                while (start < end && arr2[start] >= arr1[start + 1])
                {
                    start++;
                    isDone = true;
                }
                temp.Add(arr2[start]);
                result.Add(temp);


                if (start == end - 1)
                {
                    temp = new List<int>() { arr1[start + 1], arr2[start + 1] };
                    result.Add(temp);
                }
                start++;
            }

            //while (start < end)
            //{
            //    List<int> tempList = new List<int>();
            //    tempList.Add(intervals[start][0]);
            //    bool isDone = false;
            //    while (intervals[start][1] >= intervals[start + 1][0])
            //    {
            //        start++;
            //        isDone = true;
            //    }

            //    tempList.Add(intervals[start][1]);
            //    result.Add(tempList);
            //    start++;
            //    if(isDone && start == end - 1)
            //    {
            //        tempList = new List<int>() { intervals[start + 1][0], intervals[start + 1][1] };
            //        result.Add(tempList);
            //    }

            //}
            return result.Select(x => x.ToArray()).ToArray();
        }

        public static bool WordPattern(string pattern, string s)
        {
            string[] tempArray = s.Split(" ");
            if (pattern.Length != tempArray.Length) return false;
            Dictionary<char, string> tempDict = new Dictionary<char, string>();

            int i = 0;
            foreach (var item in pattern)
            {
                var m = tempDict.Where(x => x.Value == tempArray[i]).Count();
                if (m > 1) return false;

                if (!tempDict.ContainsKey(item))
                {
                    tempDict.Add(item, tempArray[i]);
                }
                else
                {
                    if (tempDict[item] != tempArray[i])
                    {
                        return false;
                    }
                }
                i++;
            }
            return true;
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {

            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> tempDict = new Dictionary<string, List<string>>();

            //List<string> tempList = new List<string>();

            foreach (var item in strs)
            {
                var temp = item.ToCharArray();

                Array.Sort(temp);

                var key = new string(temp);

                if (tempDict.ContainsKey(key))
                {
                    tempDict[key].Add(item);
                }
                else
                {
                    tempDict.Add(key, new List<string>() { item });
                }

            }

            foreach (var item in tempDict)
            {
                List<string> tempList = new List<string>();
                foreach (var ii in item.Value)
                {
                    tempList.Add(ii);
                }
                result.Add(tempList);
            }
            return result;
        }

        private static void printFizz()
        {
            Console.Write("Fizz ");
        }
        private static void printBuzz()
        {
            Console.Write("Buzz ");
        }

        private static void printFizzBuzz()
        {
            Console.Write("FizzBuzz ");
        }

        private static void printNumber(int n)
        {

            Console.Write($"{n} ");
        }

        public static int MaxPoints(int[][] points)
        {
            if (points.Length <= 2) return points.Length;

       
            int res = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                int x1 = points[i][0];
                int y1 = points[i][1];
                Dictionary<double, int> slopeCount = new Dictionary<double, int>();

                for (int j = i + 1; j < points.Length; j++)
                {

                    int x2 = points[j][0];
                    int y2 = points[j][1];

                    if (x1 == x2 && y1 == y2) continue;

                    float xDiff = x2 - x1;
                    float yDiff = y2 - y1;
                    double slope;
                    if (xDiff == 0)
                    {
                        slope = Int64.MaxValue;

                    }
                    else
                    {
                         slope = yDiff / xDiff;
                        
                    }

                    if (!slopeCount.ContainsKey(slope))
                    {
                        slopeCount.Add(slope, 1);
                    }
                    else
                    {
                        slopeCount[slope]++;
                    }

                    if (slopeCount[slope] > res)
                        res = slopeCount[slope];


                    Console.WriteLine($"({x1}, {y1}) and ({x2},{y2})  -  {slope}");
                }
            }


            return res+1;
        }
    }


    

}
