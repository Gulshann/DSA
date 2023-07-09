using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA.Algorithms
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Tree
    {
        public Tree()
        {
            TreeNode head = null;
            for(int i = 0; i < 10; i++)
            {
                int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //foreach(var item in data)
                //{
                //    InsertIntoTree(head, item);

                //}
            }

            PrintTree(head);

        }
        private void PrintTree(TreeNode head)
        {
            if (head == null)
                return;

            PrintTree(head.left);

            Console.Write(head.val);
            
            PrintTree(head.right);
        }

        //private TreeNode InsertIntoTree(TreeNode head, int data)
        //{


        //    while(head!=null)
        //}

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            int dif = targetSum - root.val;
            if (dif==0 && root.left == null && root.right==null)
            {
                return true;
            }

           return  HasPathSum(root.left, dif) || HasPathSum(root.right, dif);

            List<int> res;
            res.OrderBy(x=>x);
        }
    }
}
