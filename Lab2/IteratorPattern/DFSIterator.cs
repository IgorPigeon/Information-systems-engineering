using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorPattern.TreeNode;

namespace IteratorPattern
{
    public class DFSIterator
    {
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public DFSIterator(TreeNode root)
        {
            queue.Enqueue(root);
        }

        public int Next()
        {
            TreeNode res;
            res = queue.Dequeue();

            if (res.Left != null)
                queue.Enqueue(res.Left);

            if (res.Right != null)
                queue.Enqueue(res.Right);

            return res.Value;
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }
    }
}
