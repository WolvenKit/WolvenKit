using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ionic.Zlib;
using WolvenKit.Model;
using WolvenKit.CR2W.Types;

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

        /// <summary>
        /// Get's possible file extensions from the redengine class
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="cvar"></param>
        /// <returns></returns>
        public static List<string> GetPossibleExtensions(byte[] bytes, CVariable cvar )
        {
            var list = new List<string>();

            if (bytes == null)
                return list;

            if (bytes.StartsWith("CFX") || bytes.StartsWith("CWS") || bytes.StartsWith("FWS") || bytes.StartsWith("GFX"))
            {
                list.Add("Decompressed flash file|*.swf");
                list.Add("Unknown file|*.*");
            }
            else if (cvar is CBitmapTexture)
            {
                list.Add("DirectDraw Surface image|*.dds");
                list.Add("Unknown file|*.*");
            }
            else
            {
                list.Add("Raw binary file|*.bin");
                list.Add("Unknown file|*.*");
            }

            return list;
        }

        /// <summary>
        /// Exports a dds or gfx file from a byte array in wkit
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="ext"></param>
        /// <param name="cvar"></param>
        /// <returns></returns>
        public static byte[] GetExportBytes(byte[] bytes, string ext, CVariable cvar)
        {
            switch (ext)
            {
                case ".swf":
                    if (bytes.StartsWith("CFX") || bytes.StartsWith("CWS"))
                    {
                        return uncompressToFWS(bytes);
                    }
                    break;
                case ".dds":
                    if (cvar is CBitmapTexture xbm)
                    {
                        return ImageUtility.Xbm2DdsBytes(xbm);
                    }
                    break;                    
            }

            return bytes;


            byte[] uncompressToFWS(byte[] _bytes)
            {
                var mem = new MemoryStream(_bytes);
                var reader = new BinaryReader(mem);
                var filetype = reader.ReadBytes(3);
                var version = reader.ReadByte();
                var size = reader.ReadUInt32();

                var memout = new MemoryStream();
                var writer = new BinaryWriter(memout);
                writer.Write((byte)'F');
                writer.Write((byte)'W');
                writer.Write((byte)'S');
                writer.Write(version);
                writer.Write(size);

                var zlib = new ZlibStream(mem, CompressionMode.Decompress);
                zlib.CopyTo(memout);

                return memout.ToArray();
            }
        }

        /// <summary>
        /// Imports a dds or gfx file to a byte array needed for wkit
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
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
            // skip the DDS header (always 128 bytes long)
            else if (filetype.StartsWith("DDS"))
            {
                reader.BaseStream.Seek(128, SeekOrigin.Begin);

                // TODO: edit CBitMapTexture class to reflect the imported image
                // width, height, compression etc - to reflect the dds header


                return reader.ReadBytes((int)reader.BaseStream.Length - 128);
            }

            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            return reader.ReadBytes((int) reader.BaseStream.Length);

            
            byte[] compressToCFX(BinaryReader _reader)
            {
                var mem = new MemoryStream();
                var writer = new BinaryWriter(mem);
                var version = _reader.ReadByte();
                var size = _reader.ReadUInt32();

                writer.Write((byte)'C');
                writer.Write((byte)'F');
                writer.Write((byte)'X');
                writer.Write(version);
                writer.Write(size);

                var zlib = new ZlibStream(_reader.BaseStream, CompressionMode.Compress, true);
                zlib.CopyTo(mem);

                return mem.ToArray();
            }
        }
    }
}