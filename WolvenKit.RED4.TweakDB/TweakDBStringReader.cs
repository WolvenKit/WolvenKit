using System.IO;
using System.Reflection;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB;

public class TweakDBStringReader
{
    public static void LoadFile(string path)
    {
        var bytes = File.ReadAllBytes(path);

        var ms = new MemoryStream(bytes);

        var oodleCompression = ms.ReadStruct<uint>();
        if (oodleCompression == Oodle.KARK)
        {
            var outputsize = ms.ReadStruct<uint>();

            // read the rest of the stream
            var outputbuffer = new byte[outputsize];

            var inbuffer = ms.ToByteArray(true);

            Oodle.Decompress(inbuffer, outputbuffer);

            ms = new MemoryStream(outputbuffer);
        }
        else
        {
            ms.Position = 0;
        }
    }
}
