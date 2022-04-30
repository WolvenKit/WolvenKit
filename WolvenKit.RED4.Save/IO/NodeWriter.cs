using System.Text;

namespace WolvenKit.RED4.Save.IO;

public class NodeWriter : BinaryWriter
{
    private List<NodeInfo> _nodeInfos;
    private List<NodeMeta> _nodeMetaInfos;
    private int _currentId;
    private int _currentDepth;
    private int _lastDepth;

    public NodeWriter() : base(new MemoryStream(), Encoding.ASCII, true)
    {
        _nodeInfos = new List<NodeInfo>();
        _nodeMetaInfos = new List<NodeMeta>();
    }

    public NodeWriter(Stream stream) : base(stream, Encoding.ASCII, true)
    {
        _nodeInfos = new List<NodeInfo>();
        _nodeMetaInfos = new List<NodeMeta>();
    }

    public void Write(NodeEntry node) => Write(node, ParserHelper.GetParser(node.Name));

    public void Write(NodeEntry node, INodeParser parser)
    {
        var isChild = _currentDepth > _lastDepth;
        var isNext = _currentDepth == _lastDepth;
        var isParent = _currentDepth < _lastDepth;

        _lastDepth = _currentDepth;
        _currentDepth++;

        var currentId = _currentId++;
        var nodeInfo = new NodeInfo
        {
            Name = node.Name,
            Offset = (int)BaseStream.Position
        };

        if (isChild)
        {
            _nodeInfos[^1].ChildId = currentId;
        }
        if (_nodeInfos.Count > 0 && isNext)
        {
            _nodeInfos[^1].ChildId = -1;
            _nodeInfos[^1].NextId = currentId;
        }
        if (isParent)
        {
            _nodeInfos[^1].ChildId = -1;
            _nodeInfos[^1].NextId = -1;
            var lastIdSameLevel = _nodeMetaInfos.LastOrDefault(n => n.Depth == _currentDepth)!.Id;
            _nodeInfos[lastIdSameLevel].NextId = currentId;
        }

        _nodeInfos.Add(nodeInfo);
        _nodeMetaInfos.Add(new NodeMeta(currentId, _currentDepth));

        Write(currentId);
        parser.Write(this, node);

        nodeInfo.Size = (int)(BaseStream.Position - nodeInfo.Offset);
        if (node.WritesOwnTrailingSize)
        {
            nodeInfo.Size -= node.TrailingSize;
        }

        _currentDepth--;
    }

    public List<NodeInfo> GetFinalizedInfos()
    {
        for (var i = _nodeInfos.Count - 1; i >= 0; i--)
        {
            if (_nodeInfos[i].ChildId == 0)
            {
                _nodeInfos[i].ChildId = -1;
            }

            if (_nodeInfos[i].NextId == 0)
            {
                _nodeInfos[i].NextId = -1;
            }
        }

        return _nodeInfos;
    }

    private class NodeMeta
    {
        public int Id { get; set; }
        public int Depth { get; set; }

        public NodeMeta(int id, int depth)
        {
            Id = id;
            Depth = depth;
        }
    }
}
