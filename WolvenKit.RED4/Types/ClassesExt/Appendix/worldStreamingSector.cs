using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class worldStreamingSector : IRedAppendix
    {
        [RED("version")]
        [REDProperty(IsIgnored = true)]
        public CInt32 Version
        {
            get => GetPropertyValue<CInt32>();
            set => SetPropertyValue<CInt32>(value);
        }

        [RED("nodeData")]
        [REDProperty(IsIgnored = true)]
        public DataBuffer NodeData
        {
            get => GetPropertyValue<DataBuffer>();
            set => SetPropertyValue<DataBuffer>(value);
        }

        [RED("nodes")]
        [REDProperty(IsIgnored = true)]
        public CArray<CHandle<worldNode>> Nodes
        {
            get => GetPropertyValue<CArray<CHandle<worldNode>>>();
            set => SetPropertyValue<CArray<CHandle<worldNode>>>(value);
        }

        [RED("nodeRefs")]
        [REDProperty(IsIgnored = true)]
        public CArray<NodeRef> NodeRefs // Could also be CString
        {
            get => GetPropertyValue<CArray<NodeRef>>();
            set => SetPropertyValue<CArray<NodeRef>>(value);
        }

        [RED("variantIndices")]
        [REDProperty(IsIgnored = true)]
        public CArray<CInt32> VariantIndices
        {
            get => GetPropertyValue<CArray<CInt32>>();
            set => SetPropertyValue<CArray<CInt32>>(value);
        }

        [RED("persistentNodeIndex")]
        [REDProperty(IsIgnored = true)]
        public CInt32 PersisentNodeIndex
        {
            get => GetPropertyValue<CInt32>();
            set => SetPropertyValue<CInt32>(value);
        }

        [RED("persistentNodes")]
        [REDProperty(IsIgnored = true)]
        public CArray<RedBaseClass> PersistentNodes
        {
            get => GetPropertyValue<CArray<RedBaseClass>>();
            set => SetPropertyValue<CArray<RedBaseClass>>(value);
        }

        [RED("variantNodes")]
        [REDProperty(IsIgnored = true)]
        public CArray<CArray<RedBaseClass>> VariantNodes
        {
            get => GetPropertyValue<CArray<CArray<RedBaseClass>>>();
            set => SetPropertyValue<CArray<CArray<RedBaseClass>>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Nodes = new CArray<CHandle<worldNode>>();
            NodeRefs = new CArray<NodeRef>();
            VariantIndices = new CArray<CInt32>();

            Version = reader.ReadCInt32();

            var innerSize = reader.BaseReader.ReadInt32();

            NodeData = reader.ReadDataBuffer();
            NodeData.GetValue().ParentTypes.Add("worldStreamingSector.transforms");
            NodeData.GetValue().Parent = this;

            //var ms = new MemoryStream(Transforms.Buffer.GetBytes());
            //var bufferReader = new StreamingSectorTransformReader(ms);
            //bufferReader.ReadBuffer(Transforms.Buffer, typeof(worldStreamingSector));

            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt1; i++)
            {
                Nodes.Add((CHandle<worldNode>)reader.ReadCHandle<worldNode>());
            }

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt2; i++)
            {
                NodeRefs.Add(reader.ReadNodeRef());
            }

            var cnt3 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt3; i++)
            {
                VariantIndices.Add(reader.ReadCInt32());
            }

            PersisentNodeIndex = reader.ReadCInt32();
        }

        public void Write(Red4Writer writer)
        {
            writer.Write(Version);

            var sizePos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.Write(NodeData);

            writer.BaseWriter.WriteVLQInt32(Nodes.Count);
            foreach (var handle in Nodes)
            {
                writer.Write((IRedHandle)handle);
            }

            writer.BaseWriter.WriteVLQInt32(NodeRefs.Count);
            foreach (var nodeRef in NodeRefs)
            {
                writer.Write(nodeRef);
            }

            writer.BaseWriter.WriteVLQInt32(VariantIndices.Count);
            foreach (var unk in VariantIndices)
            {
                writer.Write(unk);
            }

            writer.Write(PersisentNodeIndex);

            var endPos = writer.BaseStream.Position;
            writer.BaseStream.Position = sizePos;
            writer.BaseWriter.Write((int)(endPos - sizePos));
            writer.BaseStream.Position = endPos;
        }
    }
}
