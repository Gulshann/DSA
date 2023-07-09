using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class SortingAlgorthims
    {
        public void BubbleSortRec(int []arr, int start, int end)
        {
            if (start > end)
                return;

            for(int j = 0; j < arr.Length - start - 1; j++)
            {
                if (arr[j] >= arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                }
            }

            BubbleSortRec(arr, start + 1, end-1);
        }

        public void BubbleSort(int [] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] >= arr[j + 1])
                    {
                        Swap(arr, j, j+1);
                    }
                }
            }
        }
        public void SelectionRec(int[] arr, int start, int end)
        {
            if (start >end)
            {
                return;
            }

            int j = start + 1;
            int index = start;

            while (j < arr.Length)
            {
                if (arr[j] <= arr[index])
                {
                    index = j;
                }
                j++;
            }

            Swap(arr, start, index);

            SelectionRec(arr, start + 1, end);

        }

        public void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
               
                int j = i + 1;
                int index = i;

                while (j < arr.Length)
                {
                    if (arr[j] <= arr[index])
                    {
                        index = j;
                    }
                    j++;
                }

                Swap(arr, i, index);
            }
        }

        public void InsertionSortRec(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return;
            }

            int temp = arr[start];
            int j = start - 1;

            while (j >= 0 && temp <= arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;

            InsertionSortRec(arr, start+1, end);

        }
        public void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while(i>=0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        public void QuickSortRec(int[] arr, int start, int end)
        {
            if (start > end)
                return;

            int p = Partition(arr, start, end);

            QuickSortRec(arr, start, p - 1);

            QuickSortRec(arr, p + 1, end);
        }

        private int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];

            int count = 0;

            //Find the exact position of the pivot element in the array - we need to count the element which is lower than the pivot element.

            for(int k = start+1; k <=end; k++)
            {
                if (pivot > arr[k])
                {
                    count++;
                }
            }

            int pivotIndex = start + count;  // Adding the start index with the count to get the pivot element index.
            Swap(arr, start, pivotIndex);  // now fixing the pivot element at its right position.

            int i = start, j = end;     //{ 1, 5, 3, 6, 2, 9, 4, 7 }

            //Bring all the elements which is lower that the pivot element to the left side (order does not matter) and vice versa.

            while (i<pivotIndex && j > pivotIndex)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i < pivotIndex && j > pivotIndex)
                {
                    Swap(arr, i++, j--);
                }

            }

            return pivotIndex;

        }

        public void Swap(int[] arr, int v1, int v2)
        {
            int temp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = temp;
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            int start = 0, end = matrix.Length - 1;
            int colLength = matrix[0].Length - 1;

            while (start <= end)
            {
                //int mid = start + (end - start) / 2;

                //if (matrix[mid][0] <= target && matrix[mid][colLength] >= target)
                //{
                //    return SearchInRow(matrix[mid], target);
                //}
                //else if (matrix[mid][0] > target)
                //{
                //    end = mid - 1;
                //}
                //else
                //{
                //    start = mid + 1;
                //}

                bool res = SearchInRow(matrix[start], target);
                if (res)
                    return true;
                start++;

            }

            return false;
        }

        public bool SearchInRow(int[] mat, int target)
        {
            int start = 0, end = mat.Length;

            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (mat[mid] == target)
                {
                    return true;
                }
                else if (target > mat[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return false;
        }

        public string AddStrings(string num1, string num2)
        {
            string result = String.Empty;
            int carry = 0;
            int l1 = num1.Length, l2 = num2.Length;
            while (l1 > l2)
            {
                num2 = "0" + num2;
                l2++;
            }
            while (l1 < l2)
            {
                num1 = "0" + num1;
                l1++;
            }
            // num1 = 011
            // num2 = 123
            for (int i = l1 - 1; i >= 0; i--)
            {
                
                int temp = Convert.ToInt32(num1[i].ToString()) + Convert.ToInt32(num2[i].ToString()) + carry;
                if (temp > 9)
                {
                    temp = temp % 10;
                    carry++;
                }
                result = temp.ToString() + result;
            }


            return result;

        }
    }
}
