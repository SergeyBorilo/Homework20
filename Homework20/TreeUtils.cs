namespace Homework20;

internal class TreeUtils
{
    public static int Height(TreeNode? node)
    {
        return node?.Height ?? 0;
    }
    public static int BalanceFactor(TreeNode? node)
    {
        return node == null ? 0 : Height(node.Left) - Height(node.Right);
    }
}


