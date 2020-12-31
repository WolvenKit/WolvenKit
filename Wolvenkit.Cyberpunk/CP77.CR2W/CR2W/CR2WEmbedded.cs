using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;

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


        //private CR2WFile parsedFile;
        
        public List<CR2WImportWrapper> ParentImports { get; set; }

        public string ClassName { get; set; } = "<failed to get class name>";
        public string ImportPath { get; set; } = "<failed to get import path>";
        public string ImportClass { get; set; } = "<failed to get import class>";

        public string Handle { get; set; }
        private byte[] Data;
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
            Data = file.ReadBytes((int) _embedded.dataSize);

            

            if (ParentImports != null && ParentImports.Any() && ParentImports.Count > (int)Embedded.importIndex - 1)
            {
                var import = ParentImports[(int)Embedded.importIndex - 1];
                ImportClass = import.ClassNameStr;
                ImportPath = import.DepotPathStr;
            }
        }

        public void WriteData(BinaryWriter file)
        {
            _embedded.dataOffset = (uint) file.BaseStream.Position;
            if (Data != null)
            {
                file.Write(Data);
            }
            _embedded.dataSize = (uint)Data.Length;
        }

        public override string ToString()
        {
            return Handle;
        }

        public CR2WFile GetParsedFile()
        {
            var parsedFile = new CR2WFile();
            switch (parsedFile.Read(Data))
            {
                case EFileReadErrorCodes.NoError:
                    break;
                case EFileReadErrorCodes.NoCr2w:
                case EFileReadErrorCodes.UnsupportedVersion:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            if (parsedFile.Chunks != null && parsedFile.Chunks.Any())
                ClassName = parsedFile.Chunks.FirstOrDefault()?.REDType;

            return parsedFile;
        }

        public async Task<CR2WFile> GetParsedFileAsync()
        {
            var parsedFile = new CR2WFile();
            switch (await parsedFile.ReadAsync(Data))
            {
                case EFileReadErrorCodes.NoError:
                    break;
                case EFileReadErrorCodes.NoCr2w:
                case EFileReadErrorCodes.UnsupportedVersion:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            if (parsedFile.Chunks != null && parsedFile.Chunks.Any())
                ClassName = parsedFile.Chunks.FirstOrDefault()?.REDType;

            return parsedFile;
        }

        public byte[] GetRawEmbeddedData() => Data;
        public void SetRawEmbeddedData(byte[] data) => Data = data;
    }
}