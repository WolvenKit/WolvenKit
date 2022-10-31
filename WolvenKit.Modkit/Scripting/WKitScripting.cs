using System;
using System.ComponentModel;
using System.IO;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;

namespace WolvenKit.Modkit.Scripting;

public class WKitScripting
{
    protected readonly ILoggerService _loggerService;
    protected IArchiveManager _archiveManager;
    protected Red4ParserService _redParserService;

    public WKitScripting(ILoggerService loggerService)
    {
        _loggerService = loggerService;

        _archiveManager = Locator.Current.GetService<IArchiveManager>();
        _redParserService = Locator.Current.GetService<Red4ParserService>();
    }

    [Description("GetFileFromBase")]
    public virtual IGameFile GetFileFromBase(string path)
    {
        var file = _archiveManager.Lookup(FNV1A64HashAlgorithm.HashString(path));
        if (file.HasValue)
        {
            return file.Value;
        }
        return null;
    }

    public virtual IGameFile GetFileFromBase(ulong hash)
    {
        var file = _archiveManager.Lookup(hash);
        if (file.HasValue)
        {
            return file.Value;
        }
        return null;
    }

    [Description("GameFileToJson")]
    public virtual string GameFileToJson(IGameFile gameFile)
    {
        if (gameFile == null)
        {
            throw new ArgumentNullException(nameof(gameFile));
        }

        using var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Position = 0;

        if (_redParserService.TryReadRed4File(ms, out var cr2w))
        {
            var dto = new RedFileDto(cr2w);
            return RedJsonSerializer.Serialize(dto);
        }

        return null;
    }

    public virtual CR2WFile JsonToCR2W(string json)
    {
        return RedJsonSerializer.Deserialize<RedFileDto>(json)?.Data;
    }
}