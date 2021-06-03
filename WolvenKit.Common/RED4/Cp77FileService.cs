using System;
using System.IO;
using System.Text;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W
{
    public class Cp77FileService : IWolvenkitFileService
    {
        #region Methods

        /// <summary>
        /// Try reading a cr2w file from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public IWolvenkitFile TryReadCr2WFile(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadCr2WFile(br);
        }

        public IWolvenkitFile TryReadCr2WFile(BinaryReader br)
        {
            // peak if cr2w
            if (br.BaseStream.Length < 4)
                return null;
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var magic = br.ReadUInt32();
            var isCr2wFile = magic == CR2WFile.MAGIC;
            if (!isCr2wFile)
                return null;

            var cr2w = new CR2WFile();
            try
            {
                //TODO: verify cr2w integrity
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.Read(br);
            }
            catch (Exception)
            {
                return null;
            }

            return cr2w;
        }

        /// <summary>
        /// Try reading the cr2w file headers only from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public IWolvenkitFile TryReadCr2WFileHeaders(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadCr2WFileHeaders(br);
        }

        public IWolvenkitFile TryReadCr2WFileHeaders(BinaryReader br)
        {
            // peak if cr2w
            if (br.BaseStream.Length < 4)
                return null;
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var magic = br.ReadUInt32();
            var isCr2wFile = magic == CR2WFile.MAGIC;
            if (!isCr2wFile)
                return null;

            var cr2w = new CR2WFile();
            try
            {
                //TODO: verify cr2w integrity
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.ReadHeaders(br);
            }
            catch (Exception)
            {
                return null;
            }

            return cr2w;
        }

        #endregion Methods
    }
}
