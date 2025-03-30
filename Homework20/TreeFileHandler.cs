namespace Homework20;

internal class TreeFileHandler
{
    public static void SaveToFile(AvlTree tree, string path)
    {
        File.WriteAllLines(path, TreeTraversal.InOrder(tree.Root).ConvertAll(x => x.ToString()));
    }

    public static void LoadFromFile(AvlTree tree, string path)
    {
        tree.Root = null;
        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
            if (int.TryParse(line, out var value)) tree.Insert(value);
    }
}
