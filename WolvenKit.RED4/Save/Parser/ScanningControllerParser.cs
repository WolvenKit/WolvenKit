using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ScanningController : Package
{
    public float Unknown1 { get; set; }
    public string Unknown2 { get; set; }
}

public class ScanningControllerParser : PackageParser
{
    public static string NodeName => Constants.NodeNames.SCANNING_CONTROLLER;

    public override void Read(BinaryReader reader, NodeEntry node)
    {
        base.Read(reader, node);

        node.Value = new ScanningController
        {
            Content = ((Package)node.Value).Content, 
            Unknown1 = reader.ReadSingle(), 
            Unknown2 = reader.ReadLengthPrefixedString()
        };
    }

    public override void Write(NodeWriter writer, NodeEntry node)
    {
        base.Write(writer, node);

        var data = (ScanningController)node.Value;

        writer.Write(data.Unknown1);
        writer.WriteLengthPrefixedString(data.Unknown2);
    }
}