using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class TreeNode
    {
        public int Value { get; set; }
        public int Count { get; set; } = 0;
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = Right = null;
        }

        public TreeNode(int value, TreeNode? left, TreeNode? right) : this(value)
        {
            Left = left;
            Right = right;
        }
    }
}
