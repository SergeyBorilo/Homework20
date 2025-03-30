namespace Homework20;

public class TreeNode(int value)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; } = null;
    public TreeNode? Right { get; set; } = null;
    public int Height { get; set; } = 1;
}
