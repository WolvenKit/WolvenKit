using System.Text;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save.IO;

public class CyberpunkSaveWriter
{
    private BinaryWriter _writer;
    private Encoding _encoding;

    public CyberpunkSaveWriter(Stream output) : this(output, Encoding.UTF8, false)
    {
    }

    public CyberpunkSaveWriter(Stream output, Encoding encoding) : this(output, encoding, false)
    {
    }

    public CyberpunkSaveWriter(Stream output, Encoding encoding, bool leaveOpen)
    {
        _writer = new BinaryWriter(output, encoding, leaveOpen);
        _encoding = encoding;
    }

    public void WriteFile(CyberpunkSaveFile file, List<RawSaveNode> rawSaveNodes)
    {
        _writer.BaseStream.WriteStruct(CyberpunkSaveFile.MAGIC);
        _writer.BaseStream.WriteStruct(file.FileHeader.FileHeader);

        var newNodes = FlattenNodeTree(file.Nodes);

        for (int i = 0; i < newNodes.Count; i++)
        {
            var oldNode = rawSaveNodes[i];
            var newNode = newNodes[i];

            if (oldNode.Name != newNode.Name)
            {

            }

            if (oldNode.NextId != newNode.NextId)
            {

            }

            if (oldNode.ChildId != newNode.ChildId)
            {

            }

            if (oldNode.Size != newNode.Size)
            {

            }
        }
    }

    private List<RawSaveNode> FlattenNodeTree(List<SaveNode> nodes)
    {
        var id = 0;

        var flatNodes = new List<RawSaveNode>();
        var rawNodes = WriteNodeInfo(nodes);

        return flatNodes.OrderBy(x => x.Id).ToList();

        List<RawSaveNode> WriteNodeInfo(List<SaveNode> nodes)
        {
            var results = new List<RawSaveNode>();

            foreach (var node in nodes)
            {
                var entry = new RawSaveNode();
                entry.Id = id++;
                entry.Name = node.Name;

                entry.Size = entry.Data.Length + entry.TrailingData.Length;
                if (node.Children.Count > 0)
                {
                    entry.Children = WriteNodeInfo(node.Children);

                    entry.ChildId = entry.Children[0].Id;
                    entry.Size += entry.Children[0].Size;

                    for (int i = 1; i < entry.Children.Count; i++)
                    {
                        entry.Children[i - 1].NextId = entry.Children[i].Id;
                        entry.Size += entry.Children[i].Size;
                    }
                }

                entry.TrailingData = node.TrailingDataBytes;

                entry.Data = new byte[node.DataBytes.Length + 4];
                Array.Copy(BitConverter.GetBytes(entry.Id), 0, entry.Data, 0, 4);
                Array.Copy(node.DataBytes, 0, entry.Data, 4, node.DataBytes.Length);

                entry.NextId = id;

                flatNodes.Add(entry);
                results.Add(entry);
            }

            results[^1].NextId = -1;

            return results;
        }
    }
}
