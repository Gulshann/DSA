using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DSA.Algorithms
{
    public class Backtracking
    {
        public Backtracking()
        {
            bool re = CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj");
            //int re=FirstUniqChar("loveleetcode");
            var result = new List<List<string>>();
            int[][] board = new int[4][];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new int[board.Length];

                for (int j = 0; j < board.Length; j++)
                {
                    board[i][j] = 0;
                }
            }
            bool isPossible = nQueen(board, 0);

            List<string> tempList = new List<string>();
            foreach (var item in board)
            {
               
                StringBuilder st = new StringBuilder();
                foreach (var internalItem in item)
                {
                    if (internalItem == 0)
                    {
                        st.Append(".");
                    }
                    else
                    {
                        st.Append("Q");
                    }
                }
                tempList.Add(st.ToString());
               
            }
            result.Add(tempList);
        }

        private bool nQueen(int[][] board, int row)
        {
            if (row == board.Length)
                return true;

            for (int col = 0; col < board.Length; col++)
            {
                if (isSafe(board, row, col))
                {
                    board[row][col] = 1;
                    if (nQueen(board, row + 1))
                    {
                        return true;
                    }
                    board[row][col] = 0;
                }
            }
            return false;
        }

        private bool isSafe(int[][] board, int row, int col)
        {

            //Column search
            for (int i = 0; i < row; i++)
            {
                if (board[i][col] == 1)
                    return false;
            }

            //Diagonal search - only top left and the top right diagonal needs to be verified

            int roww = row;
            int coll = col;

            while (roww >= 0 && coll >= 0)
            {
                if (board[roww][coll] == 1)
                {
                    return false;
                }
                roww--;
                coll--;
            }

            roww = row;
            coll = col;

            while (roww >= 0 && coll < board.Length)
            {
                if (board[roww][coll] == 1)
                {
                    return false;
                }
                roww--;
                coll++;
            }




            return true;
        }

        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> tempList = new Dictionary<char, int>();

            var m=s.ToList<char>();

            List<char> removedList = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!tempList.ContainsKey(s[i]) && !removedList.Contains(s[i]))
                {
                    tempList.Add(s[i], i);
                }
                else
                {
                    removedList.Add(s[i]);
                    tempList.Remove(s[i]);
                    //return tempList[s[i]];
                }
            }
            if (tempList.Count > 0)
                return tempList.OrderBy(x => x.Value).FirstOrDefault().Value;
           
            return -1;
        }


        public bool CanConstruct(string ransomNote, string magazine)
        {

            Dictionary<char, int> ransomNoteDict = new Dictionary<char, int>();
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();
            List<char> tempList = new List<char>();

            foreach (var item in ransomNote)
            {
                if (!ransomNoteDict.ContainsKey(item))
                {
                    ransomNoteDict.Add(item, 1);
                    tempList.Add(item);
                }
                else
                {
                    ransomNoteDict[item]++;
                }
            }
            
            foreach (var item in magazine)
            {
                if (!magazineDict.ContainsKey(item))
                {
                    magazineDict.Add(item, 1);
                    
                }
                else
                {
                    magazineDict[item]++;
                }
            }

            foreach (var item in ransomNoteDict)
            {
                if (magazineDict.ContainsKey(item.Key) && magazineDict[item.Key] == item.Value)
                {
                    tempList.Remove(item.Key);
                    continue;
                }
                else
                {
                    return false;
                }
            }

            if (tempList.Count == 0) return true;

            else
            {
                return false;
            }



        }
    }
}
