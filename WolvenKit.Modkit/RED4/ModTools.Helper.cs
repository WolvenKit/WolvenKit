using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4;

public partial class ModTools
{
    private enum FindFileResult
    {
        NoError,
        FileNotFound,
        NoCR2W
    }

    private class FindFileEntry
    {
        public CR2WFile File { get; }
        public List<IRedImport> Imports { get; }

        public FindFileEntry(CR2WFile file, List<IRedImport> imports)
        {
            File = file;
            Imports = imports;
        }
    }

    private FindFileResult TryFindFile(List<ICyberGameArchive> archives, CName path, out FindFileEntry? result, bool excludeCustomArchives = false)
    {
        var status = InternalTryFindFile(archives, path, out result, excludeCustomArchives);

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

    private FindFileResult InternalTryFindFile(List<ICyberGameArchive> archives, ulong hash, out FindFileEntry? result, bool excludeCustomArchives = false)
    {
        result = null;

        foreach (var archive in archives)
        {
            if (excludeCustomArchives && archive is not Archive)
            {
                continue;
            }

            if (archive.Files.TryGetValue(hash, out var gameFile))
            {
                var ms = new MemoryStream();
                gameFile.Extract(ms);
                ms.Seek(0, SeekOrigin.Begin);

                using var reader = new CR2WReader(ms);
                reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

                if (reader.ReadFile(out var file) != EFileReadErrorCodes.NoError)
                {
                    return FindFileResult.NoCR2W;
                }

                result = new FindFileEntry(file, reader.ImportsList);

                return FindFileResult.NoError;
            }
        }

        return FindFileResult.FileNotFound;
    }

    private bool UncookFile(List<ICyberGameArchive> archives, string path, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false) => UncookFile(archives, FNV1A64HashAlgorithm.HashString(path), matRepo, args, excludeCustomArchives);

    private bool UncookFile(List<ICyberGameArchive> archives, ulong hash, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false)
    {
        foreach (var archive in archives)
        {
            if (excludeCustomArchives && archive is not Archive)
            {
                continue;
            }

            if (archive.Files.TryGetValue(hash, out var gameFile))
            {
                var di = new DirectoryInfo(matRepo);
                if (!di.Exists)
                {
                    di.Create();
                }

                return UncookSingle(archive, gameFile.Key, di, args);
            }
        }

        return false;
    }
}
