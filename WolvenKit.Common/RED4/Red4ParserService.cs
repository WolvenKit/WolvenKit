#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using WolvenKit.Common.Services;
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
        /// Try reading a <see cref="CR2WFile">CR2WFile</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="stream">The <see cref="Stream">Stream</see> to read from</param>
        /// <param name="redFile">The resulting <see cref="CR2WFile">CR2WFile</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4File(Stream stream, [NotNullWhen(true)] out CR2WFile? redFile)
        {
            using var reader = new CR2WReader(stream);
            return reader.ReadFile(out redFile) == EFileReadErrorCodes.NoError;
        }

        /// <summary>
        /// Try reading <see cref="CR2WFile">CR2WFile</see> from a <see cref="BinaryReader">BinaryReader</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <param name="redFile">The resulting <see cref="CR2WFile">CR2WFile</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4File(BinaryReader br, [NotNullWhen(true)] out CR2WFile? redFile)
        {
            using var reader = new CR2WReader(br);
            return reader.ReadFile(out redFile) == EFileReadErrorCodes.NoError;
        }

        /// <summary>
        /// Reads a <see cref="CR2WFile">CR2WFile</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="stream">The <see cref="Stream">Stream</see> to read from</param>
        /// <returns>The resulting <see cref="CR2WFile">CR2WFile</see> or null if unsuccessful</returns>
        public CR2WFile? ReadRed4File(Stream stream)
        {
            TryReadRed4File(stream, out var redFile);
            return redFile;
        }

        /// <summary>
        /// Reads a <see cref="CR2WFile">CR2WFile</see> from a <see cref="BinaryReader">BinaryReader</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <returns>The resulting <see cref="CR2WFile">CR2WFile</see> or null if unsuccessful</returns>
        public CR2WFile? ReadRed4File(BinaryReader br)
        {
            TryReadRed4File(br, out var redFile);
            return redFile;
        }

        /// <summary>
        /// Try reading a <see cref="CR2WFileInfo">CR2WFileInfo</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="stream">The <see cref="Stream">Stream</see> to read from</param>
        /// <param name="info">The resulting <see cref="CR2WFileInfo">CR2WFileInfo</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4FileHeaders(Stream stream, [NotNullWhen(true)] out CR2WFileInfo? info)
        {
            using var reader = new CR2WReader(stream);
            return reader.ReadFileInfo(out info) == EFileReadErrorCodes.NoError;
        }

        /// <summary>
        /// Try reading a <see cref="CR2WFileInfo">CR2WFileInfo</see> from a <see cref="BinaryReader">BinaryReader</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <param name="info">The resulting <see cref="CR2WFileInfo">CR2WFileInfo</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4FileHeaders(BinaryReader br, [NotNullWhen(true)] out CR2WFileInfo? info)
        {
            using var reader = new CR2WReader(br);
            return reader.ReadFileInfo(out info) == EFileReadErrorCodes.NoError;
        }

        /// <summary>
        /// Reads a <see cref="CR2WFileInfo">CR2WFileInfo</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="stream">The <see cref="Stream">Stream</see> to read from</param>
        /// <returns>The resulting <see cref="CR2WFileInfo">CR2WFileInfo</see> or null if unsuccessful</returns>
        public CR2WFileInfo? ReadRed4FileHeaders(Stream stream)
        {
            TryReadRed4FileHeaders(stream, out var info);
            return info;
        }

        /// <summary>
        /// Reads a <see cref="CR2WFileInfo">CR2WFileInfo</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <returns>The resulting <see cref="CR2WFileInfo">CR2WFileInfo</see> or null if unsuccessful</returns>
        public CR2WFileInfo? ReadRed4FileHeaders(BinaryReader br)
        {
            TryReadRed4FileHeaders(br, out var info);
            return info;
        }

        /// <summary>
        /// Checks if a stream is a cr2w file
        /// seeks to the beginning of the stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public bool IsCR2WFile(Stream stream, bool seek = true)
        {
            if (seek)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }

            // peak if cr2w
            if (stream.Length < 4)
            {
                return false;
            }

            var word = new byte[4];
            stream.Read(word, 0, 4);
            var magic = BitConverter.ToUInt32(word, 0);

            stream.Seek(-4, SeekOrigin.Current);

            if (magic != CR2WFile.MAGIC)
            {
                return false;
            }

            return true;
        }

        #endregion Methods

    }
}
