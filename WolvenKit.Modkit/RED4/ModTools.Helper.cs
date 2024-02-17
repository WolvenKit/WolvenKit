using System.Collections.Generic;
using System.IO;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.Modkit.RED4;

public enum FindFileResult
{
    NoError,
    FileNotFound,
    NoCR2W
}

public record FindFileRecord(ICyberGameArchive? Archive, CR2WFile? File, List<IRedImport>? Imports, bool IsEmbedded = false);

public partial class ModTools
{
    private FindFileResult TryFindFile(ResourcePath path, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        var status = InternalTryFindFile(path, out result, excludeCustomArchives);

        var pathStr = path.GetResolvedText();
        if (status == FindFileResult.FileNotFound)
        {
            if (string.IsNullOrEmpty(pathStr))
            {
                _loggerService?.Warning($"The file with the hash \"{(ulong)path}\" could not be found!");
            }
            else
            {
                _loggerService?.Warning($"The file \"{pathStr}\" could not be found!");
            }
        }

        if (status == FindFileResult.NoCR2W)
        {
            if (string.IsNullOrEmpty(pathStr))
            {
                _loggerService?.Error($"The file with the hash \"{(ulong)path}\" could not be parsed!");
            }
            else
            {
                _loggerService?.Error($"The file \"{pathStr}\" could not be parsed!");
            }
        }

        return status;
    }

    private FindFileResult InternalTryFindFile(ulong hash, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        var gameFile = _archiveManager.GetGameFile(hash, true, !excludeCustomArchives);
        if (gameFile == null)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.FileNotFound;
        }

        var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Seek(0, SeekOrigin.Begin);

        using var reader = new CR2WReader(ms);
        reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

        if (reader.ReadFile(out var file) != EFileReadErrorCodes.NoError)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.NoCR2W;
        }

        result = new FindFileRecord((ICyberGameArchive)gameFile.GetArchive(), file, reader.ImportsList);
        return FindFileResult.NoError;
    }

    private bool UncookFile(string path, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false) => UncookFile(FNV1A64HashAlgorithm.HashString(path), matRepo, args, excludeCustomArchives);

    private bool UncookFile(ulong hash, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false)
    {
        if (InternalTryFindFile(hash, out var result, excludeCustomArchives) != FindFileResult.NoError)
        {
            return false;
        }

        var di = new DirectoryInfo(matRepo);
        if (!di.Exists)
        {
            di.Create();
        }

        return UncookSingle(result!.Archive!, hash, di, args);
    }
}
