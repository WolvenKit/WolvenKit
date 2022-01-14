using System.IO;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Common.Services
{
    public interface IRedParserService
    {
        CR2WFile TryReadRed4File(Stream stream);

        CR2WFile TryReadRed4FileHeaders(Stream stream);
    }
}
