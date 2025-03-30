using Homework20;

var tree = new AvlTree();
var rando = new Random();
for (var i = 0; i < 100; i++) tree.Insert(rando.Next(100));

Console.WriteLine("InOrder Traversal: " + string.Join(",", TreeTraversal.InOrder(tree.Root)));

var filePath = "tree.txt";
TreeFileHandler.SaveToFile(tree, filePath);
Console.WriteLine("Tree saved to file.");
var treeFromFile = new AvlTree();
TreeFileHandler.LoadFromFile(treeFromFile, filePath);
Console.WriteLine("Loaded tree: " + string.Join(",", TreeTraversal.InOrder(treeFromFile.Root)));

var dict = TreeDictionary.ToDictionary(treeFromFile.Root);
Console.WriteLine("Dictionary: ");
foreach (var (key, value) in dict) Console.WriteLine($"{key} -> {value}");
