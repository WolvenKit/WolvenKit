using System.Reflection;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ParserHelper
{
    private static readonly Dictionary<string, Type> _parsers = new();
    private static List<string> _allowedParserNames = new();
    private static bool _isLoaded;
    private static bool _isLimited=false;

    public static void LimitParsers(List<string> allowedParserNames)
    {
        _isLimited = true;
        _allowedParserNames = allowedParserNames;
    }

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

        if ((!_isLimited||_allowedParserNames.Contains(nodeName)) && _parsers.ContainsKey(nodeName))
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
            child.ReadByParent = true;
        }
    }

    public static void ReadNode(BinaryReader reader, NodeEntry node)
    {
        reader.BaseStream.Position = node.Offset;
        reader.ReadInt32(); // nodeId
        var parser = GetParser(node.Name);
        parser.Read(reader, node);
    }

    public static void WriteChildren(NodeWriter writer, NodeEntry node)
    {
        foreach (var child in node.Children)
        {
            writer.Write(child);
        }
    }
}
