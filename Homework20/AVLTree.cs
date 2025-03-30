namespace Homework20;

internal class AvlTree
{
    public TreeNode? Root { get; set; }

    public void Insert(int value)
    {
        Root = InsertRecurcive(Root, value);
    }
    private TreeNode InsertRecurcive(TreeNode? node, int value)
    {
        if (node == null) return new TreeNode(value);
        if (value < node.Value) node.Left = InsertRecurcive(node.Left, value);
        else if (value > node.Value) node.Right = InsertRecurcive(node.Right, value);

        node.Height = Math.Max(TreeUtils.Height(node.Left), TreeUtils.Height(node.Right)) + 1;
        var balance = TreeUtils.BalanceFactor(node);

        switch (balance)
        {
            case > 1 when node.Left != null && value < node.Left.Value:
                return TreeRotations.RotateRight(node);
            case < -1 when node.Right != null && value > node.Right.Value:
                return TreeRotations.RotateLeft(node);
            case > 1 when node.Left != null && value > node.Left.Value:
                node.Left = TreeRotations.RotateLeft(node.Left);
                return TreeRotations.RotateRight(node);
        }

        if (balance >= -1 || node.Right == null || value >= node.Right.Value) return node;
        node.Right = TreeRotations.RotateRight(node.Right);
        return TreeRotations.RotateLeft(node);
    }
}
