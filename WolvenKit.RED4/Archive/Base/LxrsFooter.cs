using System.Text;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive;

public class LxrsFooter
{
    public const int MIN_LENGTH = 20;

    public const uint s_magic = 0x4C585253; //1397905484;
    private const uint s_version = 1;
    
    public List<string> FileInfos { init; get; }
    private readonly Encoding _iso8859 = Encoding.GetEncoding("ISO-8859-1");

    public LxrsFooter(List<string> fileInfos) => FileInfos = fileInfos;

    public void Write(BinaryWriter bw)
    {
        bw.Write(LxrsFooter.s_magic);
        bw.Write(LxrsFooter.s_version);

        using var ms = new MemoryStream();
        using var tempBw = new BinaryWriter(ms);
        foreach (var s in FileInfos)
        {
            tempBw.WriteNullTerminatedString(s, _iso8859);
        }

        var inBuffer = ms.ToByteArray();

        IEnumerable<byte> outBuffer = new List<byte>();
        var r = Oodle.Compress(inBuffer, ref outBuffer, false);

        bw.Write(inBuffer.Length);  // size
        // avoid possible multiple enumerations
        var outArray = outBuffer as byte[] ?? outBuffer.ToArray();
        bw.Write(outArray.Length);  // zsize
        bw.Write(FileInfos.Count);  // count
        bw.Write(outArray);
    }

    public void Read(BinaryReader br)
    {
        var magic = br.ReadUInt32();
        if (magic != s_magic)
        {
            throw new InvalidParsingException("not a valid Archive");
        }

        var version = br.ReadUInt32();
        var size = br.ReadInt32();
        var zsize = br.ReadInt32();
        var count = br.ReadInt32();

        var inBuffer = br.ReadBytes(zsize);
        byte[] buffer;

        if (size > zsize)
        {
            // buffer is compressed
            buffer = new byte[size];
            // TODO: handle result accordingly if r != size
            var r = Oodle.Decompress(inBuffer, buffer);
        }
        else if (size < zsize)
        {
            // error
            // extract as .bin file
            return;
        }
        else
        {
            // no compression
            buffer = inBuffer;
        }
        
        using var ms = new MemoryStream(buffer);
        using var tempBr = new BinaryReader(ms);
        for (var i = 0; i < count; i++)
        {
            FileInfos.Add(tempBr.ReadNullTerminatedString(_iso8859));
        }
    }
}