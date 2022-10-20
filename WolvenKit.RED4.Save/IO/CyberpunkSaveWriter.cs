using System.Text;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save.IO;

public class CyberpunkSaveWriter : IDisposable
{
    private readonly BinaryWriter _writer;
    private readonly Encoding _encoding;
    private bool _disposed;

    private CyberpunkSaveFile _file;

    public List<NodeInfo> NodeInfos;

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

    public void WriteFile(CyberpunkSaveFile file, bool compress = true)
    {
        _file = file;

        _writer.Write(CyberpunkSaveFile.MAGIC);
        _writer.Write(file.FileHeader);

        var uncompressedData = GetNodeData(out var nodeInfos);
        NodeInfos = nodeInfos;

        var dataOffset = (int)(_writer.BaseStream.Position + 8 + (_file.CompressionSettings.TableEntriesCount * 12));
        foreach (var nodeInfo in nodeInfos)
        {
            nodeInfo.Offset += dataOffset;
        }

        Compression.Write(_writer, uncompressedData, _file.CompressionSettings, compress);

        var lastBlockOffset = (int)_writer.BaseStream.Position;
        var footerWithoutLast8Bytes = BuildFooterWithoutLastEightBytes(nodeInfos);

        _writer.Write(footerWithoutLast8Bytes);
        _writer.Write(lastBlockOffset);
        _writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.END_OF_FILE));
    }

    private byte[] GetNodeData(out List<NodeInfo> nodeInfos)
    {
        byte[] uncompressedData;

        using (var ms = new MemoryStream())
        {
            using (var nw = new NodeWriter(ms))
            {
                foreach (var node in _file.Nodes)
                {
                    nw.Write(node);
                }

                nodeInfos = nw.GetFinalizedInfos();
            }
            uncompressedData = ms.ToArray();
        }

        return uncompressedData;
    }

    private byte[] BuildFooterWithoutLastEightBytes(List<NodeInfo> nodeInfos)
    {
        byte[] result;
        using (var stream = new MemoryStream())
        {
            using (var writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.NODE_INFORMATION_START));
                writer.WriteVLQInt32(nodeInfos.Count);
                foreach (var node in nodeInfos)
                {
                    writer.WriteLengthPrefixedString(node.Name);
                    writer.Write(node.NextId);
                    writer.Write(node.ChildId);
                    writer.Write(node.Offset);
                    writer.Write(node.Size);
                }
            }
            result = stream.ToArray();
        }
        return result;
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _writer.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}
