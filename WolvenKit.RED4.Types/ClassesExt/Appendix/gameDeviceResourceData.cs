using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameDeviceResourceData : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var innerSize = reader.BaseReader.ReadInt32();

            var result = new gameDeviceResourceData_Appendix();

            result.Unk1 = new gameDeviceResourceData_Appendix1[reader.BaseReader.ReadInt32()];
            for (int i = 0; i < result.Unk1.Length; i++)
            {
                result.Unk1[i] = new gameDeviceResourceData_Appendix1();

                result.Unk1[i].Hash = reader.ReadCUInt64();
                result.Unk1[i].ClassName = reader.ReadCName();

                result.Unk1[i].Children = new CUInt64[reader.BaseReader.ReadVLQInt32()];
                result.Unk1[i].Parents = new CUInt64[reader.BaseReader.ReadVLQInt32()];

                for (int j = 0; j < result.Unk1[i].Children.Length; j++)
                {
                    result.Unk1[i].Children[j] = reader.BaseReader.ReadUInt64();
                }

                for (int j = 0; j < result.Unk1[i].Parents.Length; j++)
                {
                    result.Unk1[i].Parents[j] = reader.BaseReader.ReadUInt64();
                }

                result.Unk1[i].NodePosition.X = reader.ReadCFloat();
                result.Unk1[i].NodePosition.Y = reader.ReadCFloat();
                result.Unk1[i].NodePosition.Z = reader.ReadCFloat();
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (gameDeviceResourceData_Appendix)Appendix;

            var startPos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.BaseWriter.Write(appendix.Unk1.Length);
            foreach (var entry in appendix.Unk1)
            {
                writer.Write(entry.Hash);
                writer.Write(entry.ClassName);

                writer.WriteVLQ(entry.Children.Length);
                writer.WriteVLQ(entry.Parents.Length);

                foreach (var child in entry.Children)
                {
                    writer.Write(child);
                }

                foreach (var parent in entry.Parents)
                {
                    writer.Write(parent);
                }

                writer.Write(entry.NodePosition.X);
                writer.Write(entry.NodePosition.Y);
                writer.Write(entry.NodePosition.Z);
            }

            var endPos = writer.BaseStream.Position;
            var bytesWritten = (int)(endPos - startPos);
            writer.BaseStream.Position = startPos;
            writer.BaseWriter.Write(bytesWritten);
            writer.BaseStream.Position = endPos;
        }
    }

    public class gameDeviceResourceData_Appendix
    {
        public gameDeviceResourceData_Appendix1[] Unk1 { get; set; }
    }

    public class gameDeviceResourceData_Appendix1
    {
        public CUInt64 Hash { get; set; }
        public CName ClassName { get; set; }
        public CUInt64[] Children { get; set; }
        public CUInt64[] Parents { get; set; }
        public Vector3 NodePosition { get; set; } = new();
    }
}
