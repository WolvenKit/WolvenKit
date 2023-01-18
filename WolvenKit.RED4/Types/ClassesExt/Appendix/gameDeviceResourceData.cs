using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameDeviceResourceData : IRedAppendix
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CArray<gameDeviceResourceData_Cls1> Unk1
        {
            get => GetPropertyValue<CArray<gameDeviceResourceData_Cls1>>();
            set => SetPropertyValue<CArray<gameDeviceResourceData_Cls1>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Unk1 = new CArray<gameDeviceResourceData_Cls1>();

            var innerSize = reader.BaseReader.ReadInt32();

            var cnt = reader.BaseReader.ReadInt32();
            for (int i = 0; i < cnt; i++)
            {
                var entry = new gameDeviceResourceData_Cls1();

                entry.Hash = reader.ReadCUInt64();
                entry.ClassName = reader.ReadCName();

                var childCnt = reader.BaseReader.ReadVLQInt32();
                var parentCnt = reader.BaseReader.ReadVLQInt32();

                for (int j = 0; j < childCnt; j++)
                {
                    entry.Children.Add(reader.BaseReader.ReadUInt64());
                }

                for (int j = 0; j < parentCnt; j++)
                {
                    entry.Parents.Add(reader.BaseReader.ReadUInt64());
                }

                entry.NodePosition.X = reader.ReadCFloat();
                entry.NodePosition.Y = reader.ReadCFloat();
                entry.NodePosition.Z = reader.ReadCFloat();

                Unk1.Add(entry);
            }
        }

        public void Write(Red4Writer writer)
        {
            var startPos = writer.BaseStream.Position;
            writer.BaseWriter.Write(0);

            writer.BaseWriter.Write(Unk1.Count);
            foreach (var entry in Unk1)
            {
                writer.Write(entry.Hash);
                writer.Write(entry.ClassName);

                writer.WriteVLQ(entry.Children.Count);
                writer.WriteVLQ(entry.Parents.Count);

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

    public class gameDeviceResourceData_Cls1 : RedBaseClass
    {
        [RED("hash")]
        [REDProperty(IsIgnored = true)]
        public CUInt64 Hash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        [RED("className")]
        [REDProperty(IsIgnored = true)]
        public CName ClassName
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }

        [RED("children")]
        [REDProperty(IsIgnored = true)]
        public CArray<CUInt64> Children
        {
            get => GetPropertyValue<CArray<CUInt64>>();
            set => SetPropertyValue<CArray<CUInt64>>(value);
        }

        [RED("parents")]
        [REDProperty(IsIgnored = true)]
        public CArray<CUInt64> Parents
        {
            get => GetPropertyValue<CArray<CUInt64>>();
            set => SetPropertyValue<CArray<CUInt64>>(value);
        }

        [RED("nodePosition")]
        [REDProperty(IsIgnored = true)]
        public Vector3 NodePosition
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }

        public gameDeviceResourceData_Cls1()
        {
            Children = new CArray<CUInt64>();
            Parents = new CArray<CUInt64>();
            NodePosition = new Vector3();
        }
    }
}
