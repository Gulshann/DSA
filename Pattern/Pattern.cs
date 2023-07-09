using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Pattern
{
    public class PatternProgramming
    {
        public void Pattern1(int n)
        {

            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int res=MaxProfit(arr);
            //int val = n;

            //for (int i = 0; i < 2 * n - 1; i++)
            //{

            //    for (int j = 0; j < 2 * n - 1; j++)
            //    {
            //        // if(i==0 || i == 2 * n - 2|| j == 0 || j == 2 * n - 2)
            //        // {
            //        //     Console.Write(n+" ");
            //        // }
            //        //else if (i == 1 || i == 2 * n - 3 || j == 2 || j == 2 * n - 3)
            //        // {
            //        //     Console.Write(n-1 + " ");
            //        //}

            //    }
            //    Console.WriteLine();

            //}
        }

        public int MaxProfit(int[] prices)
        {

            int lsf = Int32.MaxValue;
            int op = 0;
            int pist = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < lsf)
                {
                    lsf = prices[i];
                }
                pist = prices[i] - lsf;
                if (op < pist)
                {
                    op = pist;
                }
            }
            return op;
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            int startRow = 0;
            int endRow = matrix.Length - 1;
            int colCount = matrix[0].Length - 1;

            while (startRow <= endRow)
            {
                int midRow = (startRow + endRow) / 2;
                if (BinarySearch(matrix[midRow], target))
                    return true;
                else
                {
                    int firstNum = matrix[midRow][0];
                    int lastNum = matrix[midRow][colCount];

                    if (target > firstNum && target < lastNum)
                        return false;
                    else if (target > lastNum)
                    {
                        startRow = midRow + 1;
                    }
                    else
                    {
                        endRow = midRow - 1;
                    }
                }
                //startRow++;
            }

            return false;
        }

        private bool BinarySearch(int[] matrix, int target)
        {
            int startRow = 0;
            int endRow = matrix.Length - 1;

            while (startRow <= endRow)
            {
                int midRow = (startRow + endRow) / 2;
                if (matrix[midRow] == target)
                    return true;

                else if (matrix[midRow] < target)
                {
                    startRow = midRow + 1;
                }
                else
                {
                    endRow = midRow - 1;
                }
            }
            return false;
        }
    }
}

