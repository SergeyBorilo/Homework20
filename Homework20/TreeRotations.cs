namespace Homework20;

internal class TreeRotations
{
    public static TreeNode RotateRight(TreeNode y)
    {
        var x = y.Left;
        var t2 = x?.Right;
        y.Left = t2;
        x.Right = y;
        y.Height = Math.Max(TreeUtils.Height(y.Left), TreeUtils.Height(y.Right)) + 1;
        x.Height = Math.Max(TreeUtils.Height(x.Left), TreeUtils.Height(x.Right)) + 1;
        return x;
    }
    public static TreeNode RotateLeft(TreeNode x)
    {
        var y = x.Right;
        var t2 = y.Left;
        y.Left = x;
        x.Right = t2;
        y.Height = Math.Max(TreeUtils.Height(y.Left), TreeUtils.Height(y.Right)) + 1;
        x.Height = Math.Max(TreeUtils.Height(x.Left), TreeUtils.Height(x.Right)) + 1;
        return x;
    }
}
