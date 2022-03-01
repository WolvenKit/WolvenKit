using System.Reflection;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ParserHelper
{
    private static readonly Dictionary<string, Type> _parsers = new();
    private static bool _isLoaded;


    private static void LoadParsers()
    {
        var baseType = typeof(INodeParser);

        foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
        {
            if (!baseType.IsAssignableFrom(type))
            {
                continue;
            }

            var prop = type.GetProperty("NodeName", BindingFlags.Public | BindingFlags.Static);
            if (prop != null)
            {
                var name = (string)prop.GetValue(null, null)!;
                _parsers.Add(name, type);
            }
        }

        _isLoaded = true;
    }

    public static INodeParser GetParser(string nodeName)
    {
        if (!_isLoaded)
        {
            LoadParsers();
        }

        if (_parsers.ContainsKey(nodeName))
        {
            return (INodeParser)System.Activator.CreateInstance(_parsers[nodeName])!;
        }

        return new DefaultParser();
    }

    public static void ReadChildren(BinaryReader reader, NodeEntry node)
    {
        foreach (var child in node.Children)
        {
            ReadNode(reader, child);
        }
    }

    public static void ReadNode(BinaryReader reader, NodeEntry node)
    {
        reader.BaseStream.Position = node.Offset;
        reader.ReadInt32(); // nodeId

        var parser = GetParser(node.Name);
        parser.Read(reader, node);
    }
}
