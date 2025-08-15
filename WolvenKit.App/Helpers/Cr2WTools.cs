using System;
using System.IO;
using System.Text;
using WolvenKit.App.Services;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public class Cr2WTools
{
    private readonly ILoggerService _loggerService;
    private readonly IHashService _hashService;
    private readonly Red4ParserService _parserService;

    public Cr2WTools(
        ILoggerService loggerService,
        IHashService hashService,
        Red4ParserService parserService
    )
    {
        _loggerService = loggerService;
        _hashService = hashService;
        _parserService = parserService;
    }


    #region cr2w

    public bool WriteCr2W(CR2WFile cr2WFile, string? absolutePath)
    {
        if (string.IsNullOrEmpty(absolutePath))
        {
            _loggerService.Error("No file path provided!");
            return false;
        }

        var fileDirectory = Path.GetDirectoryName(absolutePath);

        if (fileDirectory is not null && !Directory.Exists(fileDirectory))
        {
            Directory.CreateDirectory(fileDirectory);
        }

        using (var ms = new MemoryStream())
        {
            try
            {
                using var writer = new CR2WWriter(ms, Encoding.UTF8, true) { LoggerService = _loggerService };
                writer.WriteFile(cr2WFile);

                if (!FileHelper.SafeWrite(ms, absolutePath, _loggerService))
                {
                    return false;
                }

                SaveHashedValues(cr2WFile);
            }
            catch (Exception e)
            {
                _loggerService.Error($"Error while saving {absolutePath}");
                _loggerService.Error(e);

                return false;
            }
            finally
            {
                ms.Close();
            }
        }

        _loggerService.Success($"Saved file {absolutePath}");
        return true;
    }

    public CR2WFile ReadCr2W(string absolutePath)
    {
        if (!File.Exists(absolutePath))
        {
            throw new InvalidDataException($"File does not exist: {absolutePath}");
        }

        using var fs = new FileStream(absolutePath, FileMode.Open);

        if (!_parserService.TryReadRed4File(fs, out var cr2WFile))
        {
            throw new InvalidFileTypeException($"Can't read file: {absolutePath}");
        }

        return cr2WFile;
    }

    #endregion

    private void SaveHashedValues(CR2WFile file)
    {
        if (_hashService is not HashServiceExt hashService)
        {
            return;
        }

        foreach (var (_, value) in file.RootChunk.GetEnumerator())
        {
            switch (value)
            {
                case IRedRef redRef when redRef.DepotPath != ResourcePath.Empty &&
                                         redRef.DepotPath.TryGetResolvedText(out var refPath):
                    hashService.AddResourcePath(refPath);
                    break;
                case TweakDBID tweakDbId
                    when tweakDbId != TweakDBID.Empty && tweakDbId.TryGetResolvedText(out var tweakName):
                    hashService.AddTweakName(tweakName);
                    break;
                default:
                    break;
            }
        }
    }
}