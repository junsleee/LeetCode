using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeGeneral
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
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            targetSum -= root.val;

            if ((root.left == null) && (root.right == null))
            {
                return targetSum == 0;
            }

            return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        }
    }
}
