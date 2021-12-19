using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class worldStreamingSector : IRedAppendix
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CInt32 Unk1
        {
            get => GetPropertyValue<CInt32>();
            set => SetPropertyValue<CInt32>(value);
        }

        [RED("unk2")]
        [REDProperty(IsIgnored = true)]
        public DataBuffer Unk2
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

        [RED("unk3")]
        [REDProperty(IsIgnored = true)]
        public CArray<CInt32> Unk3
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

        public void Read(Red4Reader reader, uint size)
        {
            Handles = new CArray<CHandle<worldNode>>();
            NodeRefs = new CArray<NodeRef>();
            Unk3 = new CArray<CInt32>();

            Unk1 = reader.ReadCInt32();

            var innerSize = reader.BaseReader.ReadInt32();

            Unk2 = reader.ReadDataBuffer();

            
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
                Unk3.Add(reader.ReadCInt32());
            }

            Unk4 = reader.ReadCInt32();
        }

        public void Write(Red4Writer writer)
        {
            writer.Write(Unk1);

            var sizePos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.Write(Unk2);

            writer.BaseWriter.WriteVLQInt32(Handles.Count);
            foreach (var handle in Handles)
            {
                writer.Write(handle);
            }

            writer.BaseWriter.WriteVLQInt32(NodeRefs.Count);
            foreach (var nodeRef in NodeRefs)
            {
                writer.Write(nodeRef);
            }

            writer.BaseWriter.WriteVLQInt32(Unk3.Count);
            foreach (var unk in Unk3)
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
