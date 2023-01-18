using IteratorPattern;

TreeNode root = new TreeNode(4);
root.Left = new TreeNode(2, new TreeNode(1), new TreeNode(3));
root.Right = new TreeNode(5);

BSTIterator iterator = new BSTIterator(root);
while (iterator.HasNext())
{
    Console.WriteLine($"{iterator.Next()} ");
}
Console.WriteLine();

DFSIterator dfsIterator = new DFSIterator(root);

while (dfsIterator.HasNext())
{
    Console.WriteLine($"{dfsIterator.Next()} ");
}



Console.Read();