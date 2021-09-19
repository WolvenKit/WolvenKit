using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class worldStreamingSector : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new worldStreamingSector_Appendix();

            var startPos = reader.BaseStream.Position;

            result.Unk1 = reader.BaseReader.ReadInt32(); // 0x3C

            var innerSize = reader.BaseReader.ReadInt32();

            result.Unk2 = reader.BaseReader.ReadInt32();
            if (result.Unk2 != -2147483647)
            {
                throw new TodoException();
            }

            result.Handles = new CHandle<worldNode>[reader.BaseReader.ReadVLQInt32()];
            for (int i = 0; i < result.Handles.Length; i++)
            {
                result.Handles[i] = (CHandle<worldNode>)reader.ReadCHandle<worldNode>();
            }

            result.NodeRefs = new NodeRef[reader.BaseReader.ReadVLQInt32()];
            for (int i = 0; i < result.NodeRefs.Length; i++)
            {
                result.NodeRefs[i] = reader.ReadNodeRef();
            }

            result.Unk3 = new int[reader.BaseReader.ReadVLQInt32()];
            for (int i = 0; i < result.Unk3.Length; i++)
            {
                result.Unk3[i] = reader.BaseReader.ReadInt32();
            }

            result.Unk4 = reader.BaseReader.ReadInt32();

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (worldStreamingSector_Appendix)Appendix;

            writer.BaseWriter.Write(appendix.Unk1);

            var sizePos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.BaseWriter.Write(appendix.Unk2);

            writer.BaseWriter.WriteVLQInt32(appendix.Handles.Length);
            foreach (var handle in appendix.Handles)
            {
                writer.Write(handle);
            }

            writer.BaseWriter.WriteVLQInt32(appendix.NodeRefs.Length);
            foreach (var nodeRef in appendix.NodeRefs)
            {
                writer.Write(nodeRef);
            }

            writer.BaseWriter.WriteVLQInt32(appendix.Unk3.Length);
            foreach (var unk in appendix.Unk3)
            {
                writer.BaseWriter.Write(unk);
            }

            writer.BaseWriter.Write(appendix.Unk4);

            var endPos = writer.BaseStream.Position;
            writer.BaseStream.Position = sizePos;
            writer.BaseWriter.Write((int)(endPos - sizePos));
            writer.BaseStream.Position = endPos;
        }
    }

    public class worldStreamingSector_Appendix
    {
        public int Unk1 { get; set; }
        public int Unk2 { get; set; }
        public CHandle<worldNode>[] Handles { get; set; }
        public NodeRef[] NodeRefs { get; set; } // Could also be CString
        public int[] Unk3 { get; set; }
        public int Unk4 { get; set; }
    }
}
