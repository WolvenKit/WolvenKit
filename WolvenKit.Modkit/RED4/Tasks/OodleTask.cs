using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Core.Compression;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public int OodleTask(FileInfo path, FileInfo outpath, bool decompress, bool compress)
    {
        if (path is null)
        {
            _loggerService.Error("No input file specifiied.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (!decompress && !compress)
        {
            _loggerService.Error("Please specify either -s or -d.");
            return ERROR_INVALID_COMMAND_LINE;
        }

        outpath ??= new FileInfo(Path.ChangeExtension(path.FullName, ".kark"));

        if (decompress)
        {
            var file = File.ReadAllBytes(path.FullName);
            using var ms = new MemoryStream(file);
            using var br = new BinaryReader(ms);

            var oodleCompression = br.ReadBytes(4);
            if (!oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b }))
            {
                throw new NotImplementedException();
            }

            var size = br.ReadUInt32();

            var buffer = br.ReadBytes(file.Length - 8);

            var unpacked = new byte[size];
            var unpackedSize = Oodle.Decompress(buffer, unpacked);

            using var msout = new MemoryStream();
            using var bw = new BinaryWriter(msout);
            bw.Write(unpacked);

            File.WriteAllBytes($"{outpath}.bin", msout.ToArray());

            _loggerService.Success($"Finished decompressing: {outpath}.bin");
        }

        if (compress)
        {
            var inbuffer = File.ReadAllBytes(path.FullName);
            IEnumerable<byte> outBuffer = new List<byte>();

            var r = Oodle.Compress(inbuffer, ref outBuffer, true);

            File.WriteAllBytes(outpath.FullName, outBuffer.ToArray());

            _loggerService.Success($"Finished compressing: {outpath}");
        }

        return ERROR_GENERAL_ERROR;
    }
}
