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

        [RED("transforms")]
        [REDProperty(IsIgnored = true)]
        public DataBuffer Transforms
        {
            get => GetPropertyValue<DataBuffer>();
            set => SetPropertyValue<DataBuffer>(value);
        }

        [RED("handles")]
        [REDProperty(IsIgnored = true)]
        public CArray<CHandle<worldNode>> Handles
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

        [RED("unk4")]
        [REDProperty(IsIgnored = true)]
        public CInt32 Unk4
        {
            get => GetPropertyValue<CInt32>();
            set => SetPropertyValue<CInt32>(value);
        }

        [RED("persistentNodes")]
        [REDProperty(IsIgnored = true)]
        public CArray<CHandle<worldNode>> PersistentNodes
        {
            get => GetPropertyValue<CArray<CHandle<worldNode>>>();
            set => SetPropertyValue<CArray<CHandle<worldNode>>>(value);
        }

        [RED("variantNodes")]
        [REDProperty(IsIgnored = true)]
        public CArray<CArray<CHandle<worldNode>>> VariantNodes
        {
            get => GetPropertyValue<CArray<CArray<CHandle<worldNode>>>>();
            set => SetPropertyValue<CArray<CArray<CHandle<worldNode>>>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Handles = new CArray<CHandle<worldNode>>();
            NodeRefs = new CArray<NodeRef>();
            VariantIndices = new CArray<CInt32>();
            VariantNodes = new CArray<CArray<CHandle<worldNode>>>();

            Version = reader.ReadCInt32();

            var innerSize = reader.BaseReader.ReadInt32();

            Transforms = reader.ReadDataBuffer();
            Transforms.GetValue().ParentTypes.Add("worldStreamingSector.transforms");

            //var ms = new MemoryStream(Transforms.Buffer.GetBytes());
            //var bufferReader = new StreamingSectorTransformReader(ms);
            //bufferReader.ReadBuffer(Transforms.Buffer, typeof(worldStreamingSector));


            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt1; i++)
            {
                Handles.Add((CHandle<worldNode>)reader.ReadCHandle<worldNode>());
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

            for (int i = 0; i < VariantIndices.Count; i++)
            {
                var ra = new CArray<CHandle<worldNode>>();
                for (int j = VariantIndices[i]; ((i + 1) < VariantIndices.Count && j < VariantIndices[i+1]) || ((i + 1) >= VariantIndices.Count && j < cnt1); j++)
                {
                    ra.Add(Handles[j]);
                }
                if (i == 0)
                {
                    PersistentNodes = ra;
                }
                else
                {
                    VariantNodes.Add(ra);
                }
            }

            Unk4 = reader.ReadCInt32();
        }

        public void Write(Red4Writer writer)
        {
            writer.Write(Version);

            var sizePos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.Write(Transforms);

            writer.BaseWriter.WriteVLQInt32(Handles.Count);
            foreach (var handle in Handles)
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

            writer.Write(Unk4);

            var endPos = writer.BaseStream.Position;
            writer.BaseStream.Position = sizePos;
            writer.BaseWriter.Write((int)(endPos - sizePos));
            writer.BaseStream.Position = endPos;
        }
    }
}
