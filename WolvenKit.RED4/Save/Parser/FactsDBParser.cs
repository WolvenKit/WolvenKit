using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class FactsDB : INodeData
{
    private List<FactsTable> _factsTables;
    private byte[] _trailingBytes;

    public byte FactsTableCount => (byte)_factsTables.Count;

    public List<FactsTable> FactsTables
    {
        get => _factsTables;
        set
        {
            _factsTables = value;
        }
    }

    public byte[] TrailingBytes
    {
        get => _trailingBytes;
        set
        {
            _trailingBytes = value;
        }
    }

    public FactsDB()
    {
        _factsTables = new List<FactsTable>();
    }
}

public class FactsDBParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.FACTSDB;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new FactsDB();
        var count = reader.ReadByte();

        // There should be count many children
        if (count != node.Children.Count)
        {
            throw new InvalidDataException($"Expected {count} FactsTable but found {node.Children.Count}.");
        }
        foreach (var child in node.Children)
        {
            ParserHelper.ReadNode(reader, child);
            child.ReadByParent = true;
            data.FactsTables.Add((FactsTable)child.Value);
        }
        // There is a blob between the last factstable and the next node in questsystem
        data.TrailingBytes = reader.ReadBytes(node.TrailingSize);
        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (FactsDB)node.Value;

        if (data.FactsTableCount != node.Children.Count)
        {
            throw new InvalidDataException($"Expected {data.FactsTableCount} FactsTable but found {node.Children.Count}.");
        }

        writer.Write(data.FactsTableCount);

        foreach (var child in node.Children)
        {
            writer.Write(child);
        }
        writer.Write(data.TrailingBytes);
    }
}