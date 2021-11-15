using System;
using System.IO;
using System.Text;
using WolvenKit.Common.Model;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.RED4.CR2W
{
    public class Red4ParserService : IRedParserService
    {
        private readonly IHashService _hashService;

        public Red4ParserService(IHashService hashService)
        {
            _hashService = hashService;
        }


        #region Methods

        /// <summary>
        /// Try reading a cr2w file from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public CR2WFile TryReadRed4File(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadRed4File(br);
        }

        public CR2WFile TryReadRed4File(BinaryReader br)
        {
            // peak if cr2w
            if (br.BaseStream.Length < 4)
            {
                return null;
            }

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var magic = br.ReadUInt32();
            var isCr2wFile = magic == CR2WFile.MAGIC;
            if (!isCr2wFile)
            {
                return null;
            }

            try
            {
                using var reader = new CR2WReader(br);
                var readResult = reader.ReadFile(out var c, false);
                return c;
            }
            catch (MissingRTTIException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Try reading the cr2w file headers only from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public CR2WFile TryReadRed4FileHeaders(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadRed4FileHeaders(br);
        }

        public CR2WFile TryReadRed4FileHeaders(BinaryReader br)
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
                using var reader = new CR2WReader(br);
                var readResult = reader.ReadFile(out var c, false);
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CompiledPackage TryReadCompiledPackage(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadCompiledPackage(br);
        }

        public CompiledPackage TryReadCompiledPackage(BinaryReader br)
        {
            var compiledbuffer = new CompiledPackage(_hashService);
            return compiledbuffer.Read(br) switch
            {
                Common.EFileReadErrorCodes.NoError => compiledbuffer,
                _ => null,
            };
        }

        #endregion Methods

    }
}
