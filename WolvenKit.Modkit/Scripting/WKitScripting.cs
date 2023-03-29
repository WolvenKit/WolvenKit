using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;

namespace WolvenKit.Modkit.Scripting;

/// <summary>
/// TODO
/// </summary>
public class WKitScripting
{
    protected readonly ILoggerService _loggerService;
    protected IArchiveManager _archiveManager;
    protected Red4ParserService _redParserService;

    public WKitScripting(ILoggerService loggerService, IArchiveManager archiveManager, Red4ParserService parserService)
    {
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _redParserService = parserService;
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    [Description("GetFileFromBase")]
    public virtual IGameFile? GetFileFromBase(string path)
    {
        var file = _archiveManager.Lookup(FNV1A64HashAlgorithm.HashString(path));
        if (file.HasValue)
        {
            return file.Value;
        }
        return null;
    }

    /// <summary>
    /// Note to myself: Don't use IEnumerable<T>
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable GetArchiveFiles()
    {
        foreach (var archive in _archiveManager.Archives.Items)
        {
            foreach (var (key, file) in archive.Files)
            {
                yield return file as FileEntry;
            }
        }
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public virtual IGameFile? GetFileFromBase(ulong hash)
    {
        var file = _archiveManager.Lookup(hash);
        if (file.HasValue)
        {
            return file.Value;
        }
        return null;
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="gameFile"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [Description("GameFileToJson")]
    public virtual string? GameFileToJson(IGameFile gameFile)
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

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public virtual CR2WFile? JsonToCR2W(string json) => RedJsonSerializer.Deserialize<RedFileDto>(json)?.Data;

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="path"></param>
    /// <param name="extension"></param>
    /// <returns></returns>
    public virtual string ChangeExtension(string path, string extension) => Path.ChangeExtension(path, extension);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public virtual bool FileExists(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        return FileExists(FNV1A64HashAlgorithm.HashString(path));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public virtual bool FileExists(ulong hash)
    {
        if (hash == 0)
        {
            return false;
        }
        
        return _archiveManager.Lookup(hash).HasValue;
    }
}