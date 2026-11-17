using System.Xml.Linq;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public DataBuffer Buffer
    {
        get => GetPropertyValue<DataBuffer>();
        set => SetPropertyValue<DataBuffer>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new DataBuffer();
    }

    public virtual void Read(Red4Reader reader, uint size)
    {
        Buffer.Buffer = RedBuffer.CreateBuffer(0, reader.BaseReader.ReadBytes((int)size));
    }

    public virtual void Write(Red4Writer writer)
    {
        writer.BaseWriter.Write(Buffer.Buffer.GetBytes());
    }

    public virtual ProcessTime GetProcessTime() => ProcessTime.OnFileProcessing;

    public virtual void LoadData(RedBaseClass cls)
    {
        // throw new NotImplementedException();
    }

    public virtual void StoreData()
    {
        // throw new NotImplementedException();
    }

    protected Dictionary<uint, List<worldCompiledNodeInstanceSetupInfo>> GetRelatedNodes(worldStreamingSector rootClass)
    {
        if (rootClass.NodeData.Data is not worldNodeDataBuffer nodeDataBuffer)
        {
            throw new Exception();
        }

        var index = -1;
        for (var i = 0; i < rootClass.Nodes.Count; i++)
        {
            if (ReferenceEquals(this, rootClass.Nodes[i].GetValue()))
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            throw new Exception();
        }

        var relatedNodes = new Dictionary<uint, List<worldCompiledNodeInstanceSetupInfo>>();
        foreach (var node in nodeDataBuffer)
        {
            if (node.NodeIdx == (ulong)index)
            {
                if (!relatedNodes.ContainsKey(node.InstanceIndex))
                {
                    relatedNodes.Add(node.InstanceIndex, new List<worldCompiledNodeInstanceSetupInfo>());
                }
                relatedNodes[node.InstanceIndex].Add(node);
            }
        }

        return relatedNodes;
    }
}
