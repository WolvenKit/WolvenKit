using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;

        [FieldOffset(4)]
        public uint path;

        [FieldOffset(8)]
        public ulong pathHash;

        [FieldOffset(16)]
        public uint dataOffset;

        [FieldOffset(20)]
        public uint dataSize;
    }

    public class CR2WEmbeddedWrapper
    {
        private CR2WEmbedded _embedded;
        public CR2WEmbedded Embedded {
            get => _embedded;
            set => _embedded = value;
        }

        //public List<string> handles = new List<string>();
        public string Handle {get;set;}
        public byte[] Data;

        public CR2WEmbeddedWrapper()
        {
            _embedded = new CR2WEmbedded();
        }

        public CR2WEmbeddedWrapper(CR2WEmbedded embedded)
        {
            _embedded = embedded;
        }

        public void SetOffset(uint offset) => _embedded.dataOffset = offset;
        
        //public string Handles => string.Join(", ", handles);

        /*public void ReadString(BinaryReader file, uint string_buffer_start)
        {
            file.BaseStream.Seek(handle_name_offset + string_buffer_start, SeekOrigin.Begin);
            for (var i = 0; i < handle_name_count; i++)
            {
                handles.Add(file.ReadCR2WString());
            }
        }*/

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_embedded.dataOffset, SeekOrigin.Begin);
            Data = file.ReadBytes((int) _embedded.dataSize);
        }

        public void WriteData(BinaryWriter file)
        {
            _embedded.dataOffset = (uint) file.BaseStream.Position;
            if (Data != null)
            {
                file.Write(Data);
            }
            _embedded.dataSize = (uint) Data.Length;
        }
    }
}