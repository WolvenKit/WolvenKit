using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;    //FIXME dynamically update this

        [FieldOffset(4)]
        public uint path;   //FIXME dynamically update this

        [FieldOffset(8)]
        public ulong pathHash; //FIXME dynamically update this

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


        private CR2WFile parsedFile;
        
        public List<CR2WImportWrapper> ParentImports { get; set; }

        public string ClassName { get; set; } = "<failed to get class name>";
        public string ImportPath { get; set; } = "<failed to get import path>";
        public string ImportClass { get; set; } = "<failed to get import class>";

        public string Handle { get; set; }
        public byte[] Data { get; set; }

        

        public CR2WEmbeddedWrapper()
        {
            _embedded = new CR2WEmbedded();
        }

        public CR2WEmbeddedWrapper(CR2WEmbedded embedded)
        {
            _embedded = embedded;

        }

        public void SetOffset(uint offset) => _embedded.dataOffset = offset;

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_embedded.dataOffset, SeekOrigin.Begin);
            Data = file.ReadBytes((int) _embedded.dataSize);

            try
            {
                parsedFile = new CR2WFile(Data);
                if (parsedFile != null)
                {
                    if (parsedFile.chunks != null && parsedFile.chunks.Any())
                        ClassName = parsedFile.chunks.FirstOrDefault().Type;
                }

                if (ParentImports != null && ParentImports.Any())
                {
                    if (ParentImports.Count > (int)Embedded.importIndex - 1)
                    {
                        var import = ParentImports[(int)Embedded.importIndex - 1];
                        ImportClass = import.ClassNameStr;
                        ImportPath = import.DepotPathStr;
                    }
                }
            }
            catch (System.Exception)
            {
                // FIXME handle exceptions
            }
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

        public override string ToString()
        {
            return Handle;
        }
    }
}