using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Common.Services
{
    public interface IRedParserService
    {
        CompiledPackage TryReadCompiledPackage(Stream stream);

        CR2WFile TryReadRED4File(Stream stream);

        CR2WFile TryReadRED4FileHeaders(Stream stream);
    }
}
