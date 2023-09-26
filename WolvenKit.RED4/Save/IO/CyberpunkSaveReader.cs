using System.Diagnostics;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save.IO;

public class CyberpunkSaveReader : IDisposable, IErrorHandler
{
    private readonly BinaryReader _reader;
    private bool _disposed;

    private CyberpunkSaveFile? _csavFile;

    public List<NodeEntry> NodeEntries;


    public CyberpunkSaveReader(Stream input) : this(input, Encoding.UTF8, false)
    {
    }

    public CyberpunkSaveReader(Stream input, Encoding encoding) : this(input, encoding, false)
    {
    }

    public CyberpunkSaveReader(Stream input, Encoding encoding, bool leaveOpen)
    {
        _reader = new BinaryReader(input, encoding, leaveOpen);
    }

    public CyberpunkSaveReader(BinaryReader reader)
    {
        _reader = reader;
    }

    public BinaryReader BaseReader => _reader;
    public Stream BaseStream => _reader.BaseStream;

    public EFileReadErrorCodes ReadFileInfo(out CyberpunkSaveHeaderStruct? info)
    {
        var id = BaseStream.ReadStruct<uint>();
        if (id != CyberpunkSaveFile.MAGIC)
        {
            info = null;
            return EFileReadErrorCodes.NoCSav;
        }

        info = BaseStream.ReadStruct<CyberpunkSaveHeaderStruct>();
        return EFileReadErrorCodes.NoError;
    }

    public EFileReadErrorCodes ReadFile(out CyberpunkSaveFile? file)
    {
        var result = ReadFileInfo(out var info);
        if (result == EFileReadErrorCodes.NoCSav || info == null)
        {
            file = null;
            return result;
        }

        if (((CyberpunkSaveHeaderStruct)info).gameVersion < (ulong)Enums.gameGameVersion.CP77_Patch_2_0)
        {
            file = null;
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        BaseStream.Seek(-8, SeekOrigin.End);
        var infoStart = BaseReader.ReadInt32();
        if (BaseReader.ReadUInt32() != CyberpunkSaveFile.DONE)
        {
            file = null;
            return EFileReadErrorCodes.NoCSav;
        }

        BaseStream.Seek(infoStart, SeekOrigin.Begin);
        if (BaseReader.ReadUInt32() != CyberpunkSaveFile.NODE)
        {
            file = null;
            return EFileReadErrorCodes.NoCSav;
        }

        _csavFile = new CyberpunkSaveFile();
        _csavFile.FileHeader = (CyberpunkSaveHeaderStruct)info!;

        var flatNodes = new List<NodeEntry>();
        var length = BaseReader.ReadVLQInt32();
        for (int i = 0; i < length; i++)
        {
            flatNodes.Add(new NodeEntry
            {
                Name = BaseReader.ReadLengthPrefixedString(),
                NextId = BaseReader.ReadInt32(),
                ChildId = BaseReader.ReadInt32(),
                Offset = BaseReader.ReadInt32(),
                Size = BaseReader.ReadInt32()
            });
        }

        NodeEntries = flatNodes;

        BaseStream.Position = 0;
        var dataStream = Compression.Decompress(_reader, out var compressionSettings);
        _csavFile.CompressionSettings = compressionSettings;

        _csavFile.Nodes = LoadFromStream(dataStream, flatNodes);

        file = _csavFile;
        return EFileReadErrorCodes.NoError;
    }

    private List<NodeEntry> LoadFromStream(Stream stream, List<NodeEntry> flatNodes)
    {
        var result = new List<NodeEntry>();

        using (BinaryReader reader = new BinaryReader(stream, Encoding.ASCII))
        {
            foreach (var node in flatNodes)
            {
                reader.BaseStream.Position = node.Offset;
                node.Id = reader.ReadInt32();
            }
            foreach (var node in flatNodes)
            {
                if (!node.IsChild)
                {
                    FindChildren(flatNodes, node, flatNodes.Count);
                }
                if (node.NextId > -1)
                {
                    node.NextNode = flatNodes.FirstOrDefault(n => n.Id == node.NextId);
                }
            }

            result.AddRange(flatNodes.Where(n => !n.IsChild));
            CalculateTrueSizes(result, (int)stream.Length);

            foreach (var node in flatNodes)
            {
                if (!node.ReadByParent)
                {
                    reader.BaseStream.Position = node.Offset;
                    reader.ReadInt32(); // nodeId
                    var parser = ParserHelper.GetParser(node.Name);
                    if (parser is IErrorHandler errorHandler)
                    {
                        errorHandler.ParsingError += HandleParsingError;
                    }

                    parser.Read(reader, node);
                }
            }
        }

        return result;
    }

    private void CalculateTrueSizes(IReadOnlyList<NodeEntry> nodes, int maxLength)
    {
        for (var i = 0; i < nodes.Count; ++i)
        {
            var currentNode = nodes[i];
            var nextNode = i + 1 < nodes.Count ? nodes[i + 1] : null;

            if (currentNode.Children.Count > 0)
            {
                // Check if there is a blob before the first child
                var nextChild = currentNode.Children.First();
                var blobSize = nextChild.Offset - currentNode.Offset;
                currentNode.DataSize = blobSize;
                CalculateTrueSizes(currentNode.Children, maxLength);
            }
            else
            {
                currentNode.DataSize = currentNode.Size;
            }

            if (nextNode != null)
            {
                // There is a node after us. Check if there is a blob in between
                var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                if (blobSize < 0)
                {
                    throw new InvalidDataException("Found a datablob with negative size");
                }
                currentNode.TrailingSize = blobSize;
            }
            else
            {
                // There might be a blob that is part of the children due to the parents size, check for that
                if (currentNode.Parent == null)
                {
                    // This is the last node on the root list. Trailing data should have been cought by the last inner child and assigned here but check again.
                    var lastNodeEnd = currentNode.Offset + currentNode.Size;
                    Debug.Assert(lastNodeEnd <= maxLength);
                    if (lastNodeEnd < maxLength)
                    {
                        // There is a trailing blob
                        currentNode.TrailingSize = maxLength - lastNodeEnd;
                    }

                    continue;
                }
                nextNode = currentNode.Parent.NextNode;
                if (nextNode == null)
                {
                    // This is the last child on the last node. The next valid offset would be the end of the data
                    // Create a virtual node for this so the code below can grab the offset
                    nextNode = new NodeEntry();
                    nextNode.Offset = maxLength;
                }
                var parentMax = currentNode.Parent.Offset + currentNode.Parent.Size;
                var childMax = currentNode.Offset + currentNode.Size;
                // The parent size should never be smaller than the end of the last child.
                Debug.Assert(parentMax >= childMax);
                var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                if (blobSize < 0)
                {
                    throw new InvalidDataException("Found a datablob with negative size");
                }
                if (parentMax > childMax)
                {
                    // Blob belongs to this child
                    currentNode.TrailingSize = blobSize;
                }
                else if (parentMax == childMax)
                {
                    // Blob belongs to the parent but as trailing.
                    currentNode.Parent.TrailingSize = blobSize;
                }
            }
        }
    }

    private void FindChildren(List<NodeEntry> nodes, NodeEntry node, int maxNextId)
    {
        if (node.ChildId > -1)
        {
            var nextId = node.NextId;
            if (nextId == -1)
            {
                nextId = maxNextId;
            }
            for (int i = node.ChildId; i < nextId; i++)
            {
                var possibleChild = nodes.FirstOrDefault(n => n.Id == i);
                if (possibleChild == null)
                {
                    throw new Exception();
                }
                if (possibleChild.ChildId > -1)//SubChild
                {
                    FindChildren(nodes, possibleChild, nextId);
                    node.AddChild(possibleChild);
                }
                else
                {
                    if (!possibleChild.IsChild)//was already added
                    {
                        node.AddChild(possibleChild);
                    }

                }
            }
        }
    }

    public event ParsingErrorEventHandler? ParsingError;

    protected virtual bool HandleParsingError(ParsingErrorEventArgs e) => ParsingError != null && ParsingError.Invoke(e);

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _reader.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}
