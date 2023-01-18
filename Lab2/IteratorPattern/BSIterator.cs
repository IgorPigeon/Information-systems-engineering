using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BSTIterator
    {
        private Stack<TreeNode> queue;
        TreeNode currentNode;

        public BSTIterator(TreeNode root)
        {
            currentNode = root;
            queue = new Stack<TreeNode>();
            while (currentNode != null)
            {
                queue.Push(currentNode);
                currentNode = currentNode.Left;    
            }
        }

        public int Next()
        {
            TreeNode? res = null;

            while (res == null && (currentNode != null || (queue.Count > 0)))
            {
                if (currentNode != null)
                {
                    queue.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = queue.Pop();
                    res = currentNode;
                    currentNode = currentNode.Right;
                }
            }

            return res.Value;

        }

        public bool HasNext()
        {
            return currentNode != null || (queue.Count > 0);
        }
    }
}
