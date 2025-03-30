namespace Homework20;

internal class TreeDictionary
{
    public static Dictionary<int, string> ToDictionary(TreeNode? root)
    {
        var dict = new Dictionary<int, string>();
        foreach (var value in TreeTraversal.InOrder(root)) dict[value] = $"Node with value {value}";
        return dict;
    }
}
