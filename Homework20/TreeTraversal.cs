namespace Homework20;

internal class TreeTraversal
{
    public static List<int> InOrder(TreeNode? root)
    {
        var result = new List<int>();
        InOrderRecurcive(root, result);
        return result;
    }

    private static void InOrderRecurcive(TreeNode? node, List<int> result)
    {
        if (node == null) return;
        InOrderRecurcive(node.Left, result);
        result.Add(node.Value);
        InOrderRecurcive(node.Right, result);
    }
}
