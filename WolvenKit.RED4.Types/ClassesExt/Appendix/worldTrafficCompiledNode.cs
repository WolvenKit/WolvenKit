using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class worldTrafficCompiledNode : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            Appendix = new BaseAppendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => writer.BaseWriter.Write(((BaseAppendix)Appendix).Buffer);
    }

    public class worldTrafficCompiledNode_Appendix
    {
        public ushort Unk1 { get; set; }
        public worldTrafficCompiledNode_Appendix1[] Unk2 { get; set; }

        public void Read(Red4Reader reader)
        {
            Unk1 = reader.BaseReader.ReadUInt16();
            Unk2 = new worldTrafficCompiledNode_Appendix1[reader.BaseReader.ReadVLQInt32()];
            for (int i = 0; i < Unk2.Length; i++)
            {
                Unk2[i] = new worldTrafficCompiledNode_Appendix1();
                Unk2[i].Read(reader);
            }
        }
    }

    public class worldTrafficCompiledNode_Appendix1
    {
        public int Unk1 { get; set; }
        public Box Aabb { get; set; }
        public byte[] Unk2 { get; set; }
        public int[] Unk3 { get; set; }

        public void Read(Red4Reader reader)
        {
            Unk1 = reader.BaseReader.ReadInt32();
            Aabb = new Box {
                Min = new Vector4
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                },
                Max = new Vector4
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                }
            };

            Unk2 = reader.BaseReader.ReadBytes(0x16);

            var arraySize = reader.BaseReader.ReadVLQInt32();
            Unk3 = new int[arraySize];
            for (int i = 0; i < Unk3.Length; i++)
            {
                Unk3[i] = reader.BaseReader.ReadInt32();
            }
        }
    }
}
