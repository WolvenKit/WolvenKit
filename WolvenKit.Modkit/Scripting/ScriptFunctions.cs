using System;
using System.Collections;
using System.Dynamic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using YamlDotNet.Serialization;

namespace WolvenKit.Modkit.Scripting;

/// <summary>
/// TODO
/// </summary>
public class ScriptFunctions
{
    protected readonly ILoggerService _loggerService;
    protected readonly IArchiveManager _archiveManager;
    protected readonly Red4ParserService _redParserService;

    public ScriptFunctions(ILoggerService loggerService, IArchiveManager archiveManager, Red4ParserService parserService)
    {
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _redParserService = parserService;
    }

    /// <summary>
    /// Gets a list of the files available in the game archives
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
    /// DEPRECATED: Please use GetFileFromArchive(path, OpenAs.GameFile)
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <returns></returns>
    [Obsolete]
    public virtual IGameFile? GetFileFromBase(string path) => (IGameFile?)GetFileFromArchive(path, OpenAs.GameFile);

    /// <summary>
    /// DEPRECATED: Please use GetFileFromArchive(hash, OpenAs.GameFile)
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <returns></returns>
    [Obsolete]
    public virtual IGameFile? GetFileFromBase(ulong hash) => (IGameFile?)GetFileFromArchive(hash, OpenAs.GameFile);

    /// <summary>
    /// Creates a json representation of the specifed game file.
    /// </summary>
    /// <param name="gameFile">The gameFile which should be converted</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public virtual string? GameFileToJson(IGameFile gameFile) => (string?)ConvertGameFile(gameFile, OpenAs.Json);

    /// <summary>
    /// Creates a CR2W game file from a json
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    [Obsolete]
    public virtual CR2WFile? JsonToCR2W(string json) => RedJsonSerializer.Deserialize<RedFileDto>(json)?.Data;

    /// <summary>
    /// Changes the extension of the provided string path
    /// </summary>
    /// <param name="path">The path of the file to change</param>
    /// <param name="extension"></param>
    /// <returns></returns>
    public virtual string ChangeExtension(string path, string extension) => Path.ChangeExtension(path, extension);

    protected virtual object? ConvertGameFile(IGameFile gameFile, OpenAs openAs)
    {
        if (openAs == OpenAs.GameFile)
        {
            return gameFile;
        }

        using var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Position = 0;

        if (!_redParserService.TryReadRed4File(ms, out var cr2w))
        {
            _loggerService.Error($"\"{gameFile.Name}\" is not a CR2W file");
            return null;
        }

        if (openAs == OpenAs.CR2W)
        {
            return cr2w;
        }

        if (openAs == OpenAs.Json)
        {
            var dto = new RedFileDto(cr2w);
            return RedJsonSerializer.Serialize(dto);
        }

        throw new ArgumentOutOfRangeException(nameof(openAs));
    }

    /// <summary>
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromArchive(string path, OpenAs openAs)
    {
        if (string.IsNullOrEmpty(path))
        {
            return null;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return GetFileFromArchive(hash, openAs);
    }

    /// <summary>
    /// Loads a file from the base archives using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromArchive(ulong hash, OpenAs openAs)
    {
        if (hash == 0)
        {
            return null;
        }

        foreach (var archive in _archiveManager.Archives.Items)
        {
            if (archive.Files.TryGetValue(hash, out var fileEntry))
            {
                return ConvertGameFile(fileEntry, openAs);
            }
        }

        return null;
    }

    /// <summary>
    /// Check if file exists in the game archives
    /// </summary>
    /// <param name="path">file path to check</param>
    /// <returns></returns>
    public virtual bool FileExistsInArchive(string path) => GetFileFromArchive(path, OpenAs.GameFile) != null;

    /// <summary>
    /// Check if file exists in the game archives
    /// </summary>
    /// <param name="hash">hash value to be checked</param>
    /// <returns></returns>
    public virtual bool FileExistsInArchive(ulong hash) => GetFileFromArchive(hash, OpenAs.GameFile) != null;

    /// <summary>
    /// Converts a YAML string to a JSON string
    /// </summary>
    /// <param name="yamlText">The YAML string to convert</param>
    /// <returns>The converted JSON string</returns>
    public virtual string YamlToJson(string yamlText)
    {
        var deserializer = new Deserializer();
        var yamlObject = deserializer.Deserialize(yamlText);

        return JsonConvert.SerializeObject(yamlObject);
    }

    /// <summary>
    /// Converts a JSON string to a YAML string
    /// </summary>
    /// <param name="jsonText">The JSON string to convert</param>
    /// <returns>The converted YAML string</returns>
    public virtual string JsonToYaml(string jsonText)
    {
        var expConverter = new ExpandoObjectConverter();
        var deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(jsonText, expConverter);
        
        var serializer = new Serializer();
        return serializer.Serialize(deserializedObject);
    }
}

public enum OpenAs
{
    GameFile,
    CR2W,
    Json
}