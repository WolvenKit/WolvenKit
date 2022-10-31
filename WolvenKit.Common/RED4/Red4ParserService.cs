#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W
{
    public class Red4ParserService : IRedParserService
    {
        private readonly IHashService _hashService;
        private readonly ILoggerService _loggerService;

        public Red4ParserService(IHashService hashService, ILoggerService loggerService)
        {
            _hashService = hashService;
            _loggerService = loggerService;

            TypeGlobal.Logger = loggerService;
        }


        #region Methods

        public bool TryReadRed4Archive(string path, IHashService hashService, [NotNullWhen(true)] out Archive.Archive? archiveFile)
        {
            try
            {
                var reader = new ArchiveReader();
                return reader.ReadArchive(path, hashService, out archiveFile) == EFileReadErrorCodes.NoError;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);

                archiveFile = null;
                return false;
            }
        }

        public Archive.Archive? ReadRed4Archive(string path, IHashService hashService)
        {
            TryReadRed4Archive(path, hashService, out var archive);
            return archive;
        }

        /// <summary>
        /// Try reading a <see cref="CR2WFile">CR2WFile</see> from a <see cref="Stream">Stream</see>
        /// </summary>
        /// <param name="stream">The <see cref="Stream">Stream</see> to read from</param>
        /// <param name="redFile">The resulting <see cref="CR2WFile">CR2WFile</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4File(Stream stream, [NotNullWhen(true)] out CR2WFile? redFile)
        {
            try
            {
                // TODO: Shouldn't be done here...
                stream.Seek(0, SeekOrigin.Begin);
                using var reader = new CR2WReader(stream, Encoding.Default, true);
                reader.ParsingError += TypeGlobal.OnParsingError;

                return reader.ReadFile(out redFile) == EFileReadErrorCodes.NoError;
            }
            catch (Exception e)
            {
                var logger = Locator.Current.GetService<ILoggerService>();
                logger?.Error(e);

                redFile = null;
                return false;
            }
        }

        /// <summary>
        /// Try reading <see cref="CR2WFile">CR2WFile</see> from a <see cref="BinaryReader">BinaryReader</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <param name="redFile">The resulting <see cref="CR2WFile">CR2WFile</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4File(BinaryReader br, [NotNullWhen(true)] out CR2WFile? redFile)
        {
            try
            {
                // TODO: Shouldn't be done here...
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                using var reader = new CR2WReader(br);
                reader.ParsingError += TypeGlobal.OnParsingError;

                return reader.ReadFile(out redFile) == EFileReadErrorCodes.NoError;
            }
            catch (Exception e)
            {
                var logger = Locator.Current.GetService<ILoggerService>();
                logger?.Error(e);

                redFile = null;
                return false;
            }
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
            try
            {
                // TODO: Shouldn't be done here...
                stream.Seek(0, SeekOrigin.Begin);
                using var reader = new CR2WReader(stream, Encoding.Default, true);
                return reader.ReadFileInfo(out info) == EFileReadErrorCodes.NoError;
            }
            catch (Exception e)
            {
                var logger = Locator.Current.GetService<ILoggerService>();
                logger?.Error(e);

                info = null;
                return false;
            }
        }

        /// <summary>
        /// Try reading a <see cref="CR2WFileInfo">CR2WFileInfo</see> from a <see cref="BinaryReader">BinaryReader</see>
        /// </summary>
        /// <param name="br">The <see cref="BinaryReader">BinaryReader</see> to read from</param>
        /// <param name="info">The resulting <see cref="CR2WFileInfo">CR2WFileInfo</see></param>
        /// <returns>Returns true if successful, otherwise false</returns>
        public bool TryReadRed4FileHeaders(BinaryReader br, [NotNullWhen(true)] out CR2WFileInfo? info)
        {
            try
            {
                // TODO: Shouldn't be done here...
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                using var reader = new CR2WReader(br);
                return reader.ReadFileInfo(out info) == EFileReadErrorCodes.NoError;
            }
            catch (Exception e)
            {
                var logger = Locator.Current.GetService<ILoggerService>();
                logger?.Error(e);

                info = null;
                return false;
            }
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

            return magic == CR2WFile.MAGIC;
        }

        #endregion Methods

    }
}
