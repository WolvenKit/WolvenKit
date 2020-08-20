using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ionic.Zlib;

namespace WolvenKit
{
    public static class ImportExportUtility
    {
        public static bool StartsWith(this byte[] bytes, string str)
        {
            if (str.Length > bytes.Length)
                return false;

            return !str.Where((t, i) => bytes[i] != t).Any();
        }

        public static List<string> GetPossibleExtensions(byte[] bytes, string varName )
        {
            var list = new List<string>();

            if (bytes == null)
                return list;

            if (bytes.StartsWith("CFX") || bytes.StartsWith("CWS") || bytes.StartsWith("FWS") || bytes.StartsWith("GFX"))
            {
                list.Add("Decompressed flash file|*.swf");
                list.Add("Unknown file|*.*");
            }
            else if (varName == "swfTexture")
            {
                list.Add("DirectDraw Surface image|*.dds");
                list.Add("Unknown file|*.*");
            }

            return list;
        }

        public static byte[] GetExportBytes(byte[] bytes, string type)
        {
            switch (type)
            {
                case ".swf":
                    if (bytes.StartsWith("CFX") || bytes.StartsWith("CWS"))
                    {
                        return uncompressToFWS(bytes);
                    }
                    break;
                case ".dds":
                    return DDSUtility.ExportAsDDS(bytes);
            }

            return bytes;
        }

        public static byte[] GetImportBytes(BinaryReader reader)
        {
            var startpos = reader.BaseStream.Position;

            var filetype = reader.ReadBytes(3);

            if (filetype.StartsWith("FWS") || filetype.StartsWith("GFX"))
            {
                if (MessageBox.Show(
                    "Imported file type detected as FWS or GFX, do you want to compress it? \n\n Import as is if not.",
                    "Import",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return compressToCFX(reader);
                }
            }
            else if (filetype.StartsWith("DDS"))
            {
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                return DDSUtility.ImportFromDDS(reader);
            }

            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            return reader.ReadBytes((int) reader.BaseStream.Length);
        }

        private static byte[] uncompressToFWS(byte[] bytes)
        {
            var mem = new MemoryStream(bytes);
            var reader = new BinaryReader(mem);
            var filetype = reader.ReadBytes(3);
            var version = reader.ReadByte();
            var size = reader.ReadUInt32();

            var memout = new MemoryStream();
            var writer = new BinaryWriter(memout);
            writer.Write((byte) 'F');
            writer.Write((byte) 'W');
            writer.Write((byte) 'S');
            writer.Write(version);
            writer.Write(size);

            var zlib = new ZlibStream(mem, CompressionMode.Decompress);
            zlib.CopyTo(memout);

            return memout.ToArray();
        }

        private static byte[] compressToCFX(BinaryReader reader)
        {
            var mem = new MemoryStream();
            var writer = new BinaryWriter(mem);
            var version = reader.ReadByte();
            var size = reader.ReadUInt32();

            writer.Write((byte) 'C');
            writer.Write((byte) 'F');
            writer.Write((byte) 'X');
            writer.Write(version);
            writer.Write(size);

            var zlib = new ZlibStream(reader.BaseStream, CompressionMode.Compress, true);
            zlib.CopyTo(mem);

            return mem.ToArray();
        }
    }
}