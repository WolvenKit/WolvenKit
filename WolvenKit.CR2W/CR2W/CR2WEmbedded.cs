using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;
using System;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;        // updated on cr2w write

        [FieldOffset(4)]
        public uint path;               // updated on cr2w write

        [FieldOffset(8)]
        public ulong pathHash;          // updated on cr2w write

        [FieldOffset(16)]
        public uint dataOffset;         // updated on data write

        [FieldOffset(20)]
        public uint dataSize;           // updated on data write
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
        public List<byte> Data { get; set; } = new List<byte>();
        public CR2WFile ParentFile { get; internal set; }

        public CR2WEmbeddedWrapper()
        {
            _embedded = new CR2WEmbedded();
        }

        public CR2WEmbeddedWrapper(CR2WEmbedded embedded)
        {
            _embedded = embedded;

        }

        public void SetOffset(uint offset) => _embedded.dataOffset = offset;
        public void SetPath(uint offset) => _embedded.path = offset;
        public void SetPathHash(ulong hash) => _embedded.pathHash = hash;
        public void SetImportIndex(uint idx) => _embedded.importIndex = idx;

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_embedded.dataOffset, SeekOrigin.Begin);
            Data = file.ReadBytes((int) _embedded.dataSize).ToList();

            try
            {
                parsedFile = new CR2WFile(Data.ToArray(), ParentFile.Logger);
                if (parsedFile != null)
                {
                    if (parsedFile.chunks != null && parsedFile.chunks.Any())
                        ClassName = parsedFile.chunks.FirstOrDefault().REDType;
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
            catch (Exception ex)
            {
                // FIXME handle exceptions
                throw new NotImplementedException();
            }
        }

        public void WriteData(BinaryWriter file)
        {
            _embedded.dataOffset = (uint) file.BaseStream.Position;
            if (Data != null)
            {
                file.Write(Data.ToArray());
            }
            _embedded.dataSize = (uint) Data.Count;
        }

        public override string ToString()
        {
            return Handle;
        }
    }
}