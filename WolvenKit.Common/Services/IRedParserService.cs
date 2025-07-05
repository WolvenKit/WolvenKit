using System.IO;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Common.Services
{
    public interface IRedParserService
    {
        CR2WFile? ReadRed4File(Stream stream);
        bool TryReadRed4File(Stream stream, out CR2WFile? redFile);

        CR2WFileInfo? ReadRed4FileHeaders(Stream stream);
        bool TryReadRed4FileHeaders(Stream stream, out CR2WFileInfo? info);
    }
}
