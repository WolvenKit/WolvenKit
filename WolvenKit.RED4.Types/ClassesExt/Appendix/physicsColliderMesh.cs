using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class physicsColliderMesh : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new physicsColliderMesh_Appendix();

            result.Unk1 = reader.BaseReader.ReadUInt16();
            result.Unk2 = new ushort[reader.ReadVLQ()];
            for (int i = 0; i < result.Unk2.Length; i++)
            {
                result.Unk2[i] = reader.BaseReader.ReadUInt16();
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer) => throw new System.NotImplementedException();
    }

    public class physicsColliderMesh_Appendix
    {
        public ushort Unk1 { get; set; }
        public ushort[] Unk2 { get; set; }
    }
}
